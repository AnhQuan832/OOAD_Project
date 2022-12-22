using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fMainPage : Form

    {
        private int orderID;
        public fMainPage()
        {
            InitializeComponent();

        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
