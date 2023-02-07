using FireSharp.Response;
using OOAD_Project.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinFormsApp1;

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
        List<int> listID = new List<int>();
        List<int> listAmount = new List<int>();
        public UsCtr_Cart()
        {
            InitializeComponent();

        }

        private void UsCtr_Cart_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.dtRent.Format = DateTimePickerFormat.Custom;
            dtRent.CustomFormat = "dd/MM/yyyy";
            dtRent.Value = dateTime.Date;

            this.dtDue.Format = DateTimePickerFormat.Custom;
            dtDue.CustomFormat = "dd/MM/yyyy";
            dtDue.Value = dateTime.Date;
            dtDue.MinDate = dateTime.Date;

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
            if (gvCart.Rows.Count != 0)
            {
                int status = 0;
                int rentID = 0;
                messsageBox.Caption = "Order successfully";
                messsageBox.Show();

                dtDue.CustomFormat = "yyyy-MM-dd";
                dtRent.CustomFormat = "yyyy-MM-dd";

                con.Open();
                string loadDT = "select STATUS_ID from STATUS where STATUS_NAME = 'Ordering'";
                SqlCommand cmd = new SqlCommand(loadDT, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        status = (int)reader["STATUS_ID"];
                    }
                    reader.Close();
                }
                con.Close();


                con.Open();
                string insert = "insert into RENT (CUSTOMER_ID, RENT_DATE, DUE_DATE, RENT_DEPOSIT, TOTAL_PRICE, STATUS) values(" +
                    fLogin.ID + ",'" + dtRent.Text + "','" + dtDue.Text
                    + "'," + lbDeposite.Text.Remove(lbDeposite.Text.IndexOf(" ")).Replace(",", "") + "," + lbRentPrice.Text.Remove(lbDeposite.Text.IndexOf(" ")).Replace(",", "") + "," + status + ")";
                cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();


                con.Open();
                loadDT = "select DISC_ID, AMOUNT from CART_DETAIL where USER_ID = " + fLogin.ID;
                cmd = new SqlCommand(loadDT, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listID.Add((int)reader["DISC_ID"]);
                        listAmount.Add((int)reader["AMOUNT"]);
                    }
                    reader.Close();
                }
                con.Close();

                con.Open();
                loadDT = "select TOP 1(RENT_ID) from RENT order by RENT_ID desc";
                cmd = new SqlCommand(loadDT, con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rentID = (int)reader["RENT_ID"];
                    }
                    reader.Close();
                }
                con.Close();

                for (int i = 0; i < listID.Count; i++)
                {
                    con.Open();
                    insert = "insert into RENT_DETAIL (RENT_ID, DISC_ID, RENT_AMOUNT) values (" + rentID + "," + listID[i] + "," + listAmount[i] + ")";
                    cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                con.Open();
                string delete = "delete from CART_DETAIL where USER_ID = " + fLogin.ID;
                cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();


                con.Close();
                UpdateCart();
            }
            else
            {
                messsageBox.Caption = "Your cart is empty!";
                messsageBox.Show();
            }

        }

        public async void UpdateCart()
        {
            adapter = new SqlDataAdapter("SELECT DISC_NAME, CD.DISC_ID, DISC_PRICE, CD.AMOUNT, DISC_PRICE*CD.AMOUNT as TOTAL "
            + "FROM CART_DETAIL CD, DISC WHERE CD.DISC_ID = DISC.DISC_ID AND CD.USER_ID = " + fLogin.ID, con);

            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);

            dataTable = new DataTable();

            adapter.FillSchema(dataTable, SchemaType.Mapped);

            adapter.Fill(dataTable);

            gvCart.DataSource = dataTable;

            current = BindingContext[dataTable];

            FireBaseConnection fireBaseConnection = new FireBaseConnection();

            string SQL = "select CART_PRICE from CART where USER_ID = " + fLogin.ID;
            lbRentPrice.Text = string.Format("{0:#,###} VNĐ", int.Parse(SQLConnection.GetFieldValues(SQL)));
            try
            {
                SQL = "select sum(AMOUNT) from CART_DETAIL where USER_ID = " + fLogin.ID;
                int discCount = int.Parse(SQLConnection.GetFieldValues(SQL)) * 30000;
                lbDeposite.Text = string.Format("{0:#,###} VNĐ", discCount);
            }
            catch (Exception ex) { }

            this.dtDue.Format = DateTimePickerFormat.Custom;
            this.dtRent.Format = DateTimePickerFormat.Custom;

            for (int i = 0; i < gvCart.Rows.Count; i++)
            {
                String path = "Disc/" + gvCart.Rows[i].Cells[2].Value.ToString();

                FirebaseResponse response = await fireBaseConnection.client.GetTaskAsync(path);
                if (response.Body != "null")
                {
                    Image_Modal image = response.ResultAs<Image_Modal>();

                    byte[] b = Convert.FromBase64String(image.Img);

                    MemoryStream ms = new MemoryStream();
                    ms.Write(b, 0, Convert.ToInt32(b.Length));

                    Bitmap bm = new Bitmap(ms, false);
                    ms.Dispose();

                    gvCart.Rows[i].Cells[0].Value = bm;
                }
                else
                {
                    gvCart.Rows[i].Cells[0].Value = (Bitmap)Resources.Cream_logo;
                }
            }
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
            int days = timeSpan.Days;
            if (days == 0)
                days = 1;
            money = 0;
            for (int i = 0; i < gvCart.Rows.Count; i++)
                money += (int)dataTable.Rows[i][3] * days;
            lbRentPrice.Text = string.Format("{0:#,###} VNĐ", money);
        }
    }
}
