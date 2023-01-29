using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_RentingDetail : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public static DataTable dataTable;
        BindingManagerBase current;
        SqlDataAdapter adapter;
        public UsCtr_RentingDetail()
        {
            InitializeComponent();
        }

        private void UsCtr_RentingDetail_Load(object sender, System.EventArgs e)
        {
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
                    lbRent.Text = string.Format("{0:#,###} VNĐ", (int)reader["TOTAL_PRICE"]);
                }
                reader.Close();
            }
            con.Close();
        }
        private string Convert(DateTime dt)
        {
            string date;
            date = dt.ToString("dd/MM/yyyy");
            return date;
        }
    }
}
