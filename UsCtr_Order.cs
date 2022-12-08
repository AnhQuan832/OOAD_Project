using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Order : UserControl
    {
        public UsCtr_Order()
        {
            InitializeComponent();
        }

        private void UsCtr_Order_Load(object sender, EventArgs e)
        {
            this.dgvOrder.Rows.Add("0001", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Not Return");
            this.dgvOrder.Rows.Add("0002", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Completed");
            this.dgvOrder.Rows.Add("0003", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Ordering");
            this.dgvOrder.Rows.Add("0004", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Not Return");
            this.dgvOrder.Rows.Add("0005", "Hoang Phuc", "18/05/2002", "16/06/2002", "30.000", "120.000", "Not Return");
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            fOrderDetail fOrderDetail = new fOrderDetail(int.Parse(dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString()), dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString());
            fOrderDetail.ShowDialog();

        }
    }
}
