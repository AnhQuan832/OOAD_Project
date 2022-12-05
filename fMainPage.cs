using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fMainPage : Form

    {
        public fMainPage()
        {
            InitializeComponent();
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
            pnView.Controls.Clear();
            pnView.Refresh();
            pnView.Controls.Add(new UsCtr_Cart());
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
            pnView.Controls.Clear();
            pnView.Refresh();
            pnView.Controls.Add(new ShopView());
        }
    }
}
