using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_OrderDetail : UserControl
    {
        public UsCtr_OrderDetail()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.CustomFormat = "dd MMM yyyy";

            this.guna2DateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.guna2DateTimePicker2.CustomFormat = "dd MMM yyyy";

            this.guna2DataGridView1.Rows.Add("0001", "Paris By Night", "01", "15.000");
            this.guna2DataGridView1.Rows.Add("0001", "Paris By Night", "01", "15.000");
            this.guna2DataGridView1.Rows.Add("0001", "Paris By Nightdfjskjfksdjfksdjfksd", "01", "15.000");
            this.guna2DataGridView1.Rows.Add("0001", "Paris By Night", "01", "15.000");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
