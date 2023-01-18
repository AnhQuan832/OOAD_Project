using OOAD_Project.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fLogin : Form
    {
        public static String ID;
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
                string login = "SELECT * FROM nguoidung WHERE username= '" + tbUsername.Text.Trim() + "' and password= '" + tbPassword.Text.Trim() + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    acc = tbUsername.Text;
                    ID = SQLConnection.GetFieldValues("SELECT ID FROM USERS WHERE USER_ID = '" + acc + "'");

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
    }

}
