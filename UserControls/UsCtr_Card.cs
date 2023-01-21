using OOAD_Project.Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Card : UserControl
    {
        bool isSubscribe = false;
        int discID;
        int userID;
        SqlCommand cmd;
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
        public UsCtr_Card(int permission, int userID, int discID)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //set permisson admin is 1 and staff is 0
            if (permission == 0)
            {
                btnJustify.Visible = false;
            }
            this.discID = discID;
            this.userID = userID;
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
                string query = "insert into COMINGDISC values (" + discID + "," + userID + ")";
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
                string query = "delete  from COMINGDISC where USER_ID = " + userID + "and DISC_ID = " + discID;
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


        }

        private void btnJustify_Click(object sender, EventArgs e)
        {
            fEditComingDisc fEditComingDisc = new fEditComingDisc(lbName.Text);
            fEditComingDisc.ShowDialog();
        }
    }
}
