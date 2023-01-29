using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class fOrderDetail : Form
    {
        int ID;
        string type;
        public fOrderDetail(int ID, string type)
        {
            InitializeComponent();
            this.ID = ID;
            this.type = type;
        }

        private void fOrderDetail_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case "Ordering":
                    usCtr_OrderDetail.BringToFront();
                    usCtr_OrderDetail.LoadData(ID);
                    break;
                case "Completed":
                    usCtr_ReturningDisc.BringToFront();
                    usCtr_ReturningDisc.LoadData(ID, 0);
                    break;
                default:
                    usCtr_ReturningDisc.BringToFront();
                    usCtr_ReturningDisc.LoadData(ID, 1);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
