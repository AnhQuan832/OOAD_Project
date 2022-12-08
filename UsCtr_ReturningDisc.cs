using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_ReturningDisc : UserControl
    {
        int ID;
        public UsCtr_ReturningDisc(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void UsCtr_ReturningDisc_Load(object sender, System.EventArgs e)
        {
            
            this.dgvReturningDisc.Rows.Add("Paris By Night1", "02", "30.000", "0","130.000", "120.000");
            this.dgvReturningDisc.Rows.Add("Paris By Night2", "02", "30.000", "0", "30.000", "120.000");
            this.dgvReturningDisc.Rows.Add("Paris By Night3", "02", "30.000", "0", "30.000", "120.000");
            this.dgvReturningDisc.Rows.Add("Paris By Night4", "02", "30.000", "0", "30.000", "120.000");
            this.dgvReturningDisc.Rows.Add("Paris By Night5", "02", "30.000", "0", "30.000", "120.000");

            tbDiscName.Text = dgvReturningDisc.Rows[0].Cells[0].Value.ToString();
        }

        private void dgvReturningDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscName.Text = dgvReturningDisc.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvReturningDisc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscName.Text = dgvReturningDisc.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
