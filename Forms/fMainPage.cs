using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fMainPage : Form

    {
        UsCtr_HomePage usCtr_HomePage;
        public fMainPage(fLogin login)
        {
            InitializeComponent();
            usCtr_HomePage = new UsCtr_HomePage(fLogin.ID);
            pnView.Controls.Add(usCtr_HomePage);
            usCtr_HomePage.BringToFront();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            shopView1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void fMainPage_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            usCtr_Cart1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            usCtr_Order1.BringToFront();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            usCtr_Manage1.BringToFront();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            usCtr_HomePage.BringToFront();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            usCtr_UserProfilecs3.BringToFront();
        }
    }
}
