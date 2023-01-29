using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_OrderDetail : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public static DataTable dataTable;
        BindingManagerBase current;
        SqlDataAdapter adapter;

        public UsCtr_OrderDetail()
        {
            InitializeComponent();
        }

        public void LoadData(int ID)
        {
            tbID.Text = ID.ToString();
            adapter = new SqlDataAdapter("select DISC_NAME, RENT_DETAIL.RENT_AMOUNT, DISC_PRICE " +
                                           "from RENT_DETAIL, DISC " +
                                            "where RENT_DETAIL.DISC_ID = DISC.DISC_ID and RENT_ID = " + ID, con);

            SqlCommandBuilder cmb = new SqlCommandBuilder(adapter);

            dataTable = new DataTable();

            adapter.FillSchema(dataTable, SchemaType.Mapped);

            adapter.Fill(dataTable);

            gvOrder.DataSource = dataTable;

            current = BindingContext[dataTable];


            con.Open();
            string loadDT = "select USER_FULLNAME, USER_ID_NUMBER, RENT_DATE, DUE_DATE, TOTAL_PRICE, RENT_DEPOSIT " +
                            "from USERS, RENT where USERS.USER_ID = RENT.CUSTOMER_ID "
                            + "and RENT_ID = " + ID;
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbUserID.Text = (string)reader["USER_ID_NUMBER"];
                    tbUserName.Text = (string)reader["USER_FULLNAME"];
                    tbRentdate.Text = Convert((DateTime)reader["RENT_DATE"]);
                    tbDuedate.Text = Convert((DateTime)reader["DUE_DATE"]);
                    lbDeposit.Text = string.Format("{0:#,###} VNĐ", (int)reader["RENT_DEPOSIT"]);
                    lbRent.Text = string.Format("{0:#,###} VNĐ", (int)reader["TOTAL_PRICE"]);
                }
                reader.Close();
            }
            con.Close();


        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private string Convert(DateTime dt)
        {
            string date;
            date = dt.ToString("dd/MM/yyyy");
            return date;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int status = 0;
            con.Open();
            string loadDT = "select STATUS_ID from STATUS where STATUS_NAME = 'Not return'";
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
            string update = "update RENT  set STATUS = " + status + " where RENT_ID = " + tbID.Text;
            cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
