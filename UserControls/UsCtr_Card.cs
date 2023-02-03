using OOAD_Project.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Card : UserControl
    {
        FireBaseConnection fireBaseConnection = new FireBaseConnection();
        bool isSubscribe = false;
        bool isClick = false;
        int discID;
        bool isEmpty = false;
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public UsCtr_Card(int permission, int discID)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //set permisson admin is 1 and staff is 0
            if (permission == 0)
            {
                btnJustify.Visible = false;
            }
            this.discID = discID;
            cbDiscName.Visible = false;
            fireBaseConnection.RetrieveImage(pbDisc, "Disc/" + discID);
        }

        public void DisableButton()
        {
            btnSubscribe.Enabled = false;
        }
        public Image ItemImage
        {
            get { return pbDisc.Image; }
            set
            {
                pbDisc.Image = value;
            }
        }

        public string ItemName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            isSubscribe = !isSubscribe;
            if (isSubscribe)
            {
                btnSubscribe.Text = "Unsubscribe";
                btnSubscribe.BorderColor = Color.FromArgb(57, 110, 176);
                btnSubscribe.BorderThickness = 2;
                btnSubscribe.FillColor = Color.White;
                btnSubscribe.ForeColor = Color.FromArgb(57, 110, 176);

                con.Open();
                string query = "insert into SUBSCRIBE values (" + discID + "," + fLogin.ID + ")";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                btnSubscribe.Text = "Subscribe";
                btnSubscribe.BorderThickness = 0;
                btnSubscribe.FillColor = Color.FromArgb(57, 110, 176);
                btnSubscribe.ForeColor = Color.FromArgb(255, 239, 214);

                con.Open();
                string query = "delete  from SUBSCRIBE where USER_ID = " + fLogin.ID + "and DISC_ID = " + discID;
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


        }

        private void btnJustify_Click(object sender, EventArgs e)
        {
            isClick = !isClick;
            if (isClick)
            {
                cbDiscName.Visible = true;
                lbName.Visible = false;
                btnJustify.IconChar = FontAwesome.Sharp.IconChar.Check;
                LoadDataToCombobox();
            }
            else
            {
                cbDiscName.Visible = false;
                lbName.Visible = true;
                btnJustify.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
                lbName.Text = cbDiscName.SelectedValue.ToString();
                btnSubscribe.Enabled = true;

                UpdateComingDisc();
            }

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please wait for a minute. We are sending email to your customers!");
            SendNotification();
            if (!isEmpty)
            {
                RemoveComingDisc();
                MessageBox.Show("Send email successfully!");
            }
            lbName.Text = "Coming soon";
            pbDisc.Image = Resources.Cream_logo;
            btnSubscribe.Enabled = false;
        }

        private void LoadDataToCombobox()
        {
            cbDiscName.Items.Clear();
            con.Open();
            string query = "select distinct(DISC_NAME) from DISC";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            cbDiscName.DataSource = dt;
            cbDiscName.DisplayMember = "Disc Name";
            cbDiscName.ValueMember = "DISC_NAME";
        }

        private void SendNotification()
        {
            UpComingDisc upComingDisc = new UpComingDisc(lbName.Text);

            con.Open();
            string query = "select USER_MAIL from SUBSCRIBE, DISC, USERS where DISC.DISC_ID = SUBSCRIBE.DISC_ID and USERS.USER_ID = SUBSCRIBE.USER_ID and DISC_NAME = '" + lbName.Text + "'";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Customer customer = new Customer(upComingDisc, reader["USER_MAIL"].ToString());
                }
            }
            else
            {
                isEmpty = true;
            }
            con.Close();
            upComingDisc.Notify();
        }

        private void UpdateComingDisc()
        {
            String discID = "";
            String discName = cbDiscName.GetItemText(cbDiscName.SelectedItem);
            con.Open();
            string query = "select DISC_ID from DISC where DISC_NAME = '" + discName + "'";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    discID = reader["DISC_ID"].ToString();
                }
            }
            con.Close();

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into COMINGDISC values(" + discID + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            fireBaseConnection.RetrieveImage(pbDisc, "Disc/" + discID);
        }
        private void RemoveComingDisc()
        {
            string discID = "";
            con.Open();
            string query = "select distinct(SUBSCRIBE.DISC_ID) from SUBSCRIBE, DISC where SUBSCRIBE.DISC_ID = DISC.DISC_ID and DISC_NAME = '" + lbName.Text + "'";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    discID = reader["DISC_ID"].ToString();
                }
            }
            con.Close();

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from SUBSCRIBE where DISC_ID = " + discID;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from COMINGDISC where DISC_ID = " + discID;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SubscribedDisc()
        {
            isSubscribe = !isSubscribe;
            btnSubscribe.Text = "Unsubscribe";
            btnSubscribe.BorderColor = Color.FromArgb(57, 110, 176);
            btnSubscribe.BorderThickness = 2;
            btnSubscribe.FillColor = Color.White;
            btnSubscribe.ForeColor = Color.FromArgb(57, 110, 176);
        }
    }
}
