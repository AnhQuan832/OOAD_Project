using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Cart : UserControl
    {

        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        SqlDataAdapter adapter;
        public static DataTable dataTable;
        BindingManagerBase current;
        SqlCommand cmd;
        int money = 0;

        public UsCtr_Cart()
        {
            InitializeComponent();
        }

        private void UsCtr_Cart_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.dtRent.Format = DateTimePickerFormat.Custom;
            dtRent.Value = dateTime;
            this.dtRent.CustomFormat = "dd MMM yyyy";

            this.dtDue.Format = DateTimePickerFormat.Custom;
            this.dtDue.CustomFormat = "dd MMM yyyy";
            dtDue.Value = dateTime;

            InitializeCart();
            UpdateCart();
        }

        public void InitializeCart()
        {
            con.Open();
            string check = "SELECT USER_ID FROM CART WHERE USER_ID = '" + fLogin.ID + "'";
            cmd = new SqlCommand(check, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {
                con.Close();
                con.Open();
                string insert = "INSERT INTO CART (USER_ID,CART_PRICE) VALUES (" + fLogin.ID + ",0)";
                cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            con.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string ID = "0001";
            messsageBox.Caption = "Your order ID is: " + ID;
            messsageBox.Show();
        }

        private void UpdateCart()
        {
            adapter = new SqlDataAdapter("SELECT DISC_NAME, DISC_PRICE, CD.AMOUNT, DISC_PRICE*CD.AMOUNT as TOTAL "
            + "FROM CART_DETAIL CD, DISC WHERE CD.DISC_ID = DISC.DISC_ID AND CD.USER_ID = " + fLogin.ID, con);

            // Bộ phát sinh lệnh
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);

            // Khởi tạo bảng 
            dataTable = new DataTable();

            // Gán dữ liệu cho dataTable
            adapter.FillSchema(dataTable, SchemaType.Mapped);

            // Lấy dữ liệu đổ vào dataTable 
            adapter.Fill(dataTable);

            // Gán dữ liệu nguồn cho DataGridView
            gvCart.DataSource = dataTable;

            // Gán nguồn
            current = BindingContext[dataTable];

            string SQL = "select CART_PRICE from CART where USER_ID = " + fLogin.ID;
            lbRentPrice.Text = string.Format("{0:#,###} VNĐ", int.Parse(SQLConnection.GetFieldValues(SQL)));
            try
            {
                SQL = "select sum(AMOUNT) from CART_DETAIL where USER_ID = " + fLogin.ID;
                int discCount = int.Parse(SQLConnection.GetFieldValues(SQL)) * 30000;
                lbDeposite.Text = string.Format("{0:#,###} VNĐ", discCount);
            }
            catch (Exception ex) { }

        }

        private void btnUpdateCart_Click(object sender, EventArgs e)
        {
            UpdateCart();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Empty cart!", "Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string discName = dataTable.Rows[current.Position][0].ToString();
            int discID = 0;
            con.Open();
            string loadDT = "select distinct(DISC_ID) from DISC where DISC_NAME = N'" + discName + "'";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    discID = (int)reader["DISC_ID"];
                }
                reader.Close();
            }
            con.Close();
            con = new SqlConnection(SQLConnection.connectionString);
            con.Open();
            cmd = new SqlCommand("DELETE FROM CART_DETAIL WHERE DISC_ID = " + discID + " and USER_ID = " + fLogin.ID, con);
            cmd.ExecuteNonQuery();
            con.Close();

            UpdateCart();

        }

        private void dtDue_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dtRent.Value);
            DateTime end = Convert.ToDateTime(dtDue.Value);
            TimeSpan timeSpan = end - start;
            int days = timeSpan.Days + 1;
            money = 0;
            for (int i = 0; i < gvCart.Rows.Count; i++)
                money += (int)dataTable.Rows[i][3] * days;
            lbRentPrice.Text = string.Format("{0:#,###} VNĐ", money);
        }
    }
}
