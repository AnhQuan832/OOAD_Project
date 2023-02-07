using OOAD_Project.Forms;
using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fLogin : Form
    {
        public static int ID;
        public static string permission;
        public static String acc;

        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                message.Caption = "Please fill out the information";
                message.Show();
            }
            else
            {
                con.Open();
                string login = "SELECT * FROM USERS WHERE user_name= '" + tbUsername.Text.Trim() + "' and user_password= '" + tbPassword.Text.Trim() + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    acc = tbUsername.Text;
                    ID = int.Parse(SQLConnection.GetFieldValues("SELECT USER_ID FROM USERS WHERE USER_NAME = '" + acc + "'"));
                    permission = (string)(SQLConnection.GetFieldValues("SELECT POSITION_NAME FROM USERS, POSITION WHERE USERS.USER_POSITION = POSITION.POSITION_ID AND USER_NAME = '" + acc + "'"));
                    this.Hide();
                    fMainPage mainPage = new fMainPage(this);
                    mainPage.ShowDialog();
                    this.Close();
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
                else
                {
                    message.Caption = "Incorrect information";
                    message.Show();
                }
            }
            con.Close();
        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnSignUp.BringToFront();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            pnSignIn.BringToFront();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbAddressSU.Text == "" || tbEmailSU.Text == ""
                || tbFullnameSU.Text == "" || tbPasswordSU.Text == "" || tbPhonenumSU.Text == "" || tbUsernameSU.Text == "" || tbAddress.Text == "")
            {
                message.Caption = "Please fill out the information";
                message.Show();
            }
            else
            {
                int pos = 0;
                con.Open();
                string loadDT = "select POSITION_ID from POSITION where POSITION_NAME = 'Customer'";
                SqlCommand cmd = new SqlCommand(loadDT, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pos = (int)reader["POSITION_ID"];
                    }
                    reader.Close();
                }
                con.Close();
                con.Open();
                string check = "SELECT USER_NAME FROM USERS WHERE USER_NAME = '" + tbUsernameSU.Text.Trim() + "'";
                cmd = new SqlCommand(check, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    message.Caption = "Username is existed!\nTry other username!";
                    message.Show();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string register = "INSERT INTO USERS (USER_NAME,USER_PASSWORD,USER_FULLNAME, USER_MAIL,USER_ID_NUMBER,USER_PHONE,USER_POSITION, USER_ADDRESS) " +
                        "VALUES (N'" + tbUsernameSU.Text.Trim() + "','" + tbPasswordSU.Text.Trim() + "','" + tbFullnameSU.Text.Trim() + "','" +
                           tbEmailSU.Text.Trim() + "'"
                        + ",N'" + tbAddressSU.Text.Trim() + "',N'" + tbPhonenumSU.Text + "'," + pos + ",N'" + tbAddress.Text.Trim() + "')";
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();

                    message.Caption = "Create new account successfully";
                    message.Show();
                }

                con.Close();
                pnSignIn.BringToFront();
            }
        }

        private void btnShowPasswordSU_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPasswordSU.Checked)
            {
                tbPasswordSU.PasswordChar = '\0';
            }
            else
            {
                tbPasswordSU.PasswordChar = '•';
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void tbAddressSU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbPhonenumSU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            fForgotPassword fForgotPassword = new fForgotPassword();
            fForgotPassword.ShowDialog();
        }
    }

}
