using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Cart : UserControl
    {
        public UsCtr_Cart()
        {
            InitializeComponent();
        }

        private void UsCtr_Cart_Load(object sender, EventArgs e)
        {
            this.guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.CustomFormat = "dd MMM yyyy";

            this.guna2DateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.guna2DateTimePicker2.CustomFormat = "dd MMM yyyy";

            guna2DataGridView1.Rows.Add(4);
            guna2DataGridView1.Rows[0].Cells[0].Value = Properties.Resources.film_poster;
            guna2DataGridView1.Rows[0].Cells[1].Value = "Assasin";
            guna2DataGridView1.Rows[0].Cells[2].Value = "2";
            guna2DataGridView1.Rows[0].Cells[3].Value = "15.000";
            guna2DataGridView1.Rows[0].Cells[4].Value = "30.000";

            guna2DataGridView1.Rows[1].Cells[0].Value = Properties.Resources.film_poster;
            guna2DataGridView1.Rows[1].Cells[1].Value = "Assasin";
            guna2DataGridView1.Rows[1].Cells[2].Value = "2";
            guna2DataGridView1.Rows[1].Cells[3].Value = "15.000";
            guna2DataGridView1.Rows[1].Cells[4].Value = "30.000";

            guna2DataGridView1.Rows[2].Cells[0].Value = Properties.Resources.film_poster;
            guna2DataGridView1.Rows[2].Cells[1].Value = "Assasin";
            guna2DataGridView1.Rows[2].Cells[2].Value = "2";
            guna2DataGridView1.Rows[2].Cells[3].Value = "15.000";
            guna2DataGridView1.Rows[2].Cells[4].Value = "30.000";

            guna2DataGridView1.Rows[3].Cells[0].Value = Properties.Resources.film_poster;
            guna2DataGridView1.Rows[3].Cells[1].Value = "Assasin";
            guna2DataGridView1.Rows[3].Cells[2].Value = "2";
            guna2DataGridView1.Rows[3].Cells[3].Value = "15.000";
            guna2DataGridView1.Rows[3].Cells[4].Value = "30.000";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string ID = "0001";
            messsageBox.Caption = "Your order ID is: " + ID;
            messsageBox.Show();
        }
    }
}
