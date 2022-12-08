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
                    pnviewOrder.Controls.Add(new UsCtr_OrderDetail(ID));
                    break;
                case "Completed":
                    pnviewOrder.Controls.Add(new UsCtr_RentingDetail(ID));
                    break;
                default:
                    pnviewOrder.Controls.Add(new UsCtr_ReturningDisc(ID));
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
