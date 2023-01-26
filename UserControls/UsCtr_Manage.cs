using LiveCharts;
using LiveCharts.Wpf;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Manage : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        SqlDataAdapter da = new SqlDataAdapter();
        public UsCtr_Manage()
        {
            InitializeComponent();
            LoadChart();
            LoadData();
        }

        private void LoadChart()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Revenue",
                    Values = new ChartValues<double> {40, 60, 50, 20, 70, 70, 80, 100, 110,130,100,  60}
                },
                //new LineSeries
                //{
                //    Title = "Series 2",
                //    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                //    PointGeometry = null
                //},

            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.None;

        }

        private void btnAddStaff_Click(object sender, System.EventArgs e)
        {
            if (tbFullname.Text == "" || tbUsername.Text == ""
                || tbPassword.Text == "" || tbIDnum.Text == "" || tbPhonenum.Text == ""
                )
            {
                MessageBox.Show("Please fill out information!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string check = "SELECT USER_NAME FROM USERS WHERE USER_NAME = '" + tbUsername.Text.Trim() + "'";
                cmd = new SqlCommand(check, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Username is exist!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Close();
                    string position = "100" + (cbPosition.SelectedIndex + 1).ToString();
                    con.Open();
                    string register = "INSERT INTO USERS (USER_NAME,USER_PASSWORD,USER_MAIL,USER_ID_NUMBER,USER_PHONE,USER_POSITON) " +
                        "VALUES (N'" + tbUsername.Text.Trim() + "','" + tbPassword.Text.Trim() + "','" +
                           tbMail.Text + "'"
                        + ",N'" + tbIDnum.Text + "',N'" + tbPhonenum.Text + "'," + position + ")";
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Account was created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
                LoadData();
            }
        }

        private void LoadData()
        {
            con.Open();
            string sql = "select USER_NAME, USER_FULLNAME, USER_PHONE, POSTION_NAME from USERS, POSITION where USERS.USER_POSITON = POSITION.POSITION_ID and POSITION_ID = 1001 or POSITION_ID = 1002";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gvStaff.DataSource = dt;
        }
    }
}
