using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_ReturningDisc : UserControl
    {
        int damageFine = 0;
        int rentID;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public static DataTable dataTable;
        BindingManagerBase current;
        SqlDataAdapter adapter;
        public UsCtr_ReturningDisc()
        {
            InitializeComponent();
        }

        private void UsCtr_ReturningDisc_Load(object sender, System.EventArgs e)
        {
            nbDamageDisc.Maximum = 0;
        }

        private void dgvReturningDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscName.Text = gvReturningDisc.Rows[e.RowIndex].Cells[1].Value.ToString();
            nbDamageDisc.Value = 0;
            nbDamageDisc.Maximum = int.Parse(gvReturningDisc.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void dgvReturningDisc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscName.Text = gvReturningDisc.Rows[e.RowIndex].Cells[1].Value.ToString();
            nbDamageDisc.Value = 0;
            nbDamageDisc.Maximum = int.Parse(gvReturningDisc.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        public void LoadData(int ID, int type)
        {
            rentID = ID;
            adapter = new SqlDataAdapter("select DISC.DISC_ID,DISC_NAME, RENT_AMOUNT, DISC_PRICE, DISC_PRICE*RENT_AMOUNT as TOTAL " +
                                           "from RENT_DETAIL, DISC " +
                                           "where RENT_DETAIL.DISC_ID = DISC.DISC_ID and RENT_ID = " + ID, con);

            SqlCommandBuilder cmb = new SqlCommandBuilder(adapter);

            dataTable = new DataTable();
            adapter.FillSchema(dataTable, SchemaType.Mapped);
            adapter.Fill(dataTable);
            gvReturningDisc.DataSource = dataTable;
            current = BindingContext[dataTable];
            if (type == 1)
            {
                DateTime dateTime = DateTime.Now;
                int days = 0;
                int totalPrice = 0;


                con.Open();
                string loadDT = "select DATEDIFF(day, DUE_DATE ,'" + dateTime.ToString("yyyy-MM-dd") + "') AS DAYS,TOTAL_PRICE, RENT_DEPOSIT " +
                                "from RENT " +
                                "where RENT_ID = " + ID;
                SqlCommand cmd = new SqlCommand(loadDT, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        days = (int)reader["DAYS"];
                        lbDeposit.Text = string.Format("{0:#,###} VNĐ", (int)reader["RENT_DEPOSIT"]);
                        totalPrice = (int)reader["TOTAL_PRICE"];

                    }
                    reader.Close();
                }
                con.Close();

                lbTotal.Text = string.Format("{0:#,###} VNĐ", totalPrice);
                if (days > 0)
                {
                    lbOverDateFine.Text = string.Format("{0:#,###} VNĐ", days * totalPrice * 2);
                }

                lnFinalPrice.Text = string.Format("{0:#,###} VNĐ", ConvertToMoney(lbOverDateFine.Text)
                    + ConvertToMoney(lbTotal.Text) - ConvertToMoney(lbDeposit.Text));
            }
            else
            {
                btnReturn.Enabled = false;
                btnUpdate.Enabled = false;
                nbDamageDisc.Enabled = false;
                gvReturningDisc.Enabled = false;

                con.Open();
                string loadDT = "select RENT_DEPOSIT, TOTAL_PRICE, DAMAGED_FINE, OVERDATE_FINE, RETURN_PRICE " +
                                "from RETURN_DISC, RENT " +
                                "where RETURN_DISC.RENT_ID = RENT.RENT_ID and RETURN_DISC.RENT_ID = " + ID;
                SqlCommand cmd = new SqlCommand(loadDT, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbDeposit.Text = string.Format("{0:#,###} VNĐ", (int)reader["RENT_DEPOSIT"]);
                        lbTotal.Text = string.Format("{0:#,###} VNĐ", (int)reader["TOTAL_PRICE"]);
                        lbOverDateFine.Text = string.Format("{0:#,###} VNĐ", (int)reader["OVERDATE_FINE"]);
                        lnFinalPrice.Text = string.Format("{0:#,###} VNĐ", (int)reader["RETURN_PRICE"]);
                        lbDmgFine.Text = string.Format("{0:#,###} VNĐ", (int)reader["DAMAGED_FINE"]);
                    }
                    reader.Close();
                }
                con.Close();

                nbDamageDisc.Maximum = 100;
                nbDamageDisc.Value = ConvertToMoney(lbDmgFine.Text) / 50000;
            }
        }

        private int ConvertToMoney(string s)
        {
            try
            {
                return int.Parse(((s.Remove(s.IndexOf(" ")).Replace(",", ""))));

            }
            catch
            {
                return 0;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbDiscName != null)
            {
                damageFine += 50000 * int.Parse(nbDamageDisc.Value.ToString());
                lbDmgFine.Text = string.Format("{0:#,###} VNĐ", damageFine);
                lnFinalPrice.Text = string.Format("{0:#,###} VNĐ", ConvertToMoney(lnFinalPrice.Text) + ConvertToMoney(lbDmgFine.Text));
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string update = "";
            DateTime dateTime = DateTime.Now;
            con.Open();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                update = "update DISC set DISC_INSTOCK = DISC_INSTOCK + " + int.Parse(gvReturningDisc.Rows[i].Cells[2].Value.ToString()) + " where DISC_ID = " + int.Parse(gvReturningDisc.Rows[i].Cells[0].Value.ToString());
                cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();

            int status = 0;
            con.Open();
            string loadDT = "select STATUS_ID from STATUS where STATUS_NAME = 'Completed'";
            cmd = new SqlCommand(loadDT, con);
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
            update = "update RENT set STATUS = " + status + " where RENT_ID = " + rentID;
            cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            update = "insert into RETURN_DISC (RENT_ID, RETURN_DATE, DAMAGED_FINE, OVERDATE_FINE, RETURN_PRICE) values (" +
                +rentID + ",'" + dateTime.ToString("yyyy-MM-dd") + "'," + ConvertToMoney(lbDmgFine.Text) + ","
                + ConvertToMoney(lbOverDateFine.Text) + "," + ConvertToMoney(lnFinalPrice.Text) + ")";
            cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
