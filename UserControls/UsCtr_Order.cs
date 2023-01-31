using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Order : UserControl
    {
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        SqlDataAdapter adapter;
        public static DataTable dataTable;
        BindingManagerBase current;
        SqlCommand cmd;
        public UsCtr_Order()
        {
            InitializeComponent();
            timer2.Start();
            LoadDataToSearchBox();
        }

        private void LoadDataToSearchBox()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            con.Open();
            string loadDT = "select USER_FULLNAME from RENT,USERS where USERS.USER_ID = RENT.CUSTOMER_ID";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    auto.Add(reader["USER_FULLNAME"].ToString());

                }
            }
            tbxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxSearch.AutoCompleteCustomSource = auto;
            con.Close();
        }

        private void UsCtr_Order_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            adapter = new SqlDataAdapter("select RENT_ID, USER_FULLNAME, RENT_DATE, DUE_DATE, RENT_DEPOSIT, TOTAL_PRICE, STATUS_NAME " +
                                        "from RENT, USERS, STATUS " +
                                         "where RENT.CUSTOMER_ID = USERS.USER_ID " +
                                         "and RENT.STATUS = STATUS.STATUS_ID", con);

            // Bộ phát sinh lệnh
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);

            // Khởi tạo bảng 
            dataTable = new DataTable();

            // Gán dữ liệu cho dataTable
            adapter.FillSchema(dataTable, SchemaType.Mapped);

            // Lấy dữ liệu đổ vào dataTable 
            adapter.Fill(dataTable);

            // Gán dữ liệu nguồn cho DataGridView
            gvOrder.DataSource = dataTable;

            // Gán nguồn
            current = BindingContext[dataTable];
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int ID = int.Parse(gvOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
            string type = gvOrder.Rows[e.RowIndex].Cells[6].Value.ToString();
            fOrderDetail fOrderDetail = new fOrderDetail(ID, type);
            fOrderDetail.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adapter = new SqlDataAdapter("select RENT_ID, USER_FULLNAME, RENT_DATE, DUE_DATE, RENT_DEPOSIT, TOTAL_PRICE, STATUS_NAME " +
                                        "from RENT, USERS, STATUS " +
                                         "where RENT.CUSTOMER_ID = USERS.USER_ID " +
                                         "and RENT.STATUS = STATUS.STATUS_ID and USER_FULLNAME = '" + tbxSearch.Text.Trim() + "'", con);

                // Bộ phát sinh lệnh
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);

                // Khởi tạo bảng 
                dataTable = new DataTable();

                // Gán dữ liệu cho dataTable
                adapter.FillSchema(dataTable, SchemaType.Mapped);

                // Lấy dữ liệu đổ vào dataTable 
                adapter.Fill(dataTable);

                // Gán dữ liệu nguồn cho DataGridView
                gvOrder.DataSource = dataTable;

                // Gán nguồn
                current = BindingContext[dataTable];
                return;
            }
        }
    }
}
