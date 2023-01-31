using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fChangePassword : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Checked)
            {
                tbNewPass.PasswordChar = '\0';
                tbOldPass.PasswordChar = '\0';

            }
            else
            {
                tbNewPass.PasswordChar = '•';
                tbOldPass.PasswordChar = '•';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnConfirm_Click(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "" || tbOldPass.Text == "")
            {
                lbNotification.Text = "Not enough information";
            }
            else
            {
                string password = "";
                con.Open();
                string loadDT = "select USER_PASSWORD from USERS where USER_ID = " + fLogin.ID;
                SqlCommand cmd = new SqlCommand(loadDT, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        password = reader["USER_PASSWORD"].ToString();
                    }
                    reader.Close();
                }
                con.Close();

                if (tbOldPass.Text != password)
                {
                    lbNotification.Text = "Incorrect current password";
                }
                else
                {
                    con.Open();
                    string update = "update USERS set USER_PASSWORD = " + tbNewPass.Text + " where USER_ID = " + fLogin.ID;
                    cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    lbNotification.Text = "Update successfully!";
                }
            }
        }
    }
}
