using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fLogin : Form
    {
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
            this.Hide();
            fMainPage fMainPage = new fMainPage();
            fMainPage.ShowDialog();
            this.Close();

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



        private void fLogin_Load(object sender, EventArgs e)
        {
            //this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            pnSignIn.BringToFront();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create new account
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnSignUp.BringToFront();
        }
    }
}
