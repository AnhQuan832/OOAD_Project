using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project.Forms
{
    public partial class fEditComingDisc : Form
    {
        bool isEmpty = false;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public fEditComingDisc(string discName)
        {
            InitializeComponent();
            if (discName.CompareTo("Coming soon") == 0)
                isEmpty = true;
        }

        private void fEditComingDisc_Load(object sender, System.EventArgs e)
        {
            LoadDataToCombobox();
            if (isEmpty)
                btnReady.Text = "Update";
            else
                btnReady.Text = "Ready";
        }

        private void LoadDataToCombobox()
        {
            con.Open();
            string query = "select DISC_NAME from DISC";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            cbDiscName.DataSource = dt;
            cbDiscName.DisplayMember = "Disc Name";
            cbDiscName.ValueMember = "DISC_NAME";
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnReady_Click(object sender, System.EventArgs e)
        {
            if (!isEmpty)
            {

                SendNotification();
                RemoveComingDisc();
            }
            else
                UpdateComingDisc();
        }




        private void SendNotification()
        {
            string discName = cbDiscName.SelectedItem.ToString();
            tbNotification.Text = "Please wait for a minute!";
            UpComingDisc upComingDisc = new UpComingDisc(discName);

            con.Open();
            string query = "select USER_MAIL from COMINGDISC, DISC, USERS where DISC.DISC_ID = COMINGDISC.DISC_ID and USERS.USER_ID = COMINGDISC.USER_ID and DISC_NAME = '" + discName + "'";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    Customer customer = new Customer(upComingDisc, reader["USER_MAIL"].ToString());
                }
            }
            con.Close();
            upComingDisc.Notify();
            tbNotification.Text = "Send notification successfully!";
        }

        private void UpdateComingDisc()
        {
            string discID = "";
            con.Open();
            string query = "select DISC_ID from DISC where DISC_NAME = '" + cbDiscName.SelectedItem.ToString() + "'";
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
            cmd.CommandText = "insert into COMINGDISC values(" + discID + ",null)";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void RemoveComingDisc()
        {
            string discID = "";
            con.Open();
            string query = "select distinct(COMINGDISC.DISC_ID) from COMINGDISC, DISC where COMINGDISC.DISC_ID = DISC.DISC_ID and DISC_NAME = '" + cbDiscName.SelectedItem.ToString() + "'";
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
            cmd.CommandText = "delete  from COMINGDISC where DISC_ID = " + discID;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
