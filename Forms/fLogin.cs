using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fLogin : Form
    {
        public static int ID;
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
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    this.Hide();
                    fMainPage mainPage = new fMainPage(this);
                    mainPage.ShowDialog();
                    this.Close();
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu bị sai, mời nhập lại", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    tbUsername.Focus();
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
    }

}
