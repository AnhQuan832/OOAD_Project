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
        DataTable dtProducer = new DataTable();
        DataTable dtGenre = new DataTable();

        public UsCtr_Manage()
        {
            InitializeComponent();
            btnImportDisc.Enabled = false;

            LoadChart();
            LoadDataStaff();
            LoadDataDisc();
            LoadDataDiscImport();
            LoadDataToComboboxDisc();
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
            if (tbMail.Text == "" || tbUsername.Text == ""
                || tbPassword.Text == "" || tbIDnum.Text == "" || tbPhonenum.Text == "" || tbAddress.Text == "")
            {
                messageBox.Caption = "Please fill out the information";
                messageBox.Show();
            }
            else
            {
                int pos = GetPositionID(cbPosition.SelectedItem.ToString());
                con.Open();
                string check = "SELECT USER_NAME FROM USERS WHERE USER_NAME = '" + tbUsername.Text.Trim() + "'";
                cmd = new SqlCommand(check, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    messageBox.Caption = "Username is existed!\nTry other username!";
                    messageBox.Show();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string register = "INSERT INTO USERS (USER_NAME,USER_PASSWORD,USER_FULLNAME, USER_MAIL,USER_ID_NUMBER,USER_PHONE,USER_POSITION, USER_ADDRESS) " +
                        "VALUES (N'" + tbUsername.Text.Trim() + "','" + tbPassword.Text.Trim() + "','" + tbFullname.Text.Trim() + "','" +
                           tbFullname.Text.Trim() + "'"
                        + ",N'" + tbIDnum.Text.Trim() + "',N'" + tbPhonenum.Text + "'," + pos + ",N'" + tbAddress.Text.Trim() + "')";
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();

                    messageBox.Caption = "Create new account successfully";
                    messageBox.Show();
                }

                con.Close();
                LoadDataStaff();
            }
        }

        private void LoadDataStaff()
        {
            if (fLogin.permission != "Admin")
            {
                btnAddStaff.Enabled = false;
            }
            con.Open();
            string sql = "select USER_NAME, USER_FULLNAME, USER_PHONE, POSITION_NAME from USERS, POSITION where USERS.USER_POSITION = POSITION.POSITION_ID and POSITION_NAME <> 'Customer'";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gvStaff.DataSource = dt;


        }

        private int GetPositionID(string position)
        {
            int pos = 0;
            cbPosition.SelectedItem.ToString();
            con.Open();
            string loadDT = "select POSITION_ID from POSITION where POSITION_NAME = '" + position + "'";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pos = (int)reader["POSITION_ID"];
                }
                reader.Close();
            }
            con.Close();
            return pos;
        }

        private void LoadDataDiscImport()
        {
            con.Open();
            string sql = "select DISC_ID, DISC_NAME, DISC_INSTOCK, DISC_PRICE from DISC";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gvListDisc.DataSource = dt;
        }

        private void LoadDataDisc()
        {
            con.Open();
            string sql = "select DISC_ID, DISC_NAME, PRODUCER_NAME, GENRE_NAME, DISC_AMOUNT, DISC_PRICE from DISC, PRODUCER, GENRE " +
                            "where DISC.DISC_PRODUCER = PRODUCER.PRODUCER_ID and DISC.DISC_GENRE = GENRE.GENRE_ID";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gvDisc.DataSource = dt;
        }

        private void LoadDataToComboboxDisc()
        {
            con.Open();
            da = new SqlDataAdapter("select PRODUCER_NAME from PRODUCER", con);
            da.Fill(dtProducer);
            con.Close();

            cbProducer.DataSource = dtProducer;
            cbProducer.DisplayMember = "Producer name";
            cbProducer.ValueMember = "PRODUCER_NAME";


            con.Open();
            da = new SqlDataAdapter("select GENRE_NAME from GENRE", con);
            da.Fill(dtGenre);
            con.Close();

            cbGenre.DataSource = dtGenre;
            cbGenre.DisplayMember = "Genre name";
            cbGenre.ValueMember = "GENRE_NAME";
        }

        private void btnAddDisc_Click(object sender, System.EventArgs e)
        {
            if (!CheckInputDisc())
            {

            }
            else
            {
                int genreID = GetGenreID();
                int producerID = GetProducerID();
                con.Open();
                string check = "SELECT DISC_NAME FROM DISC WHERE DISC_NAME = '" + tbDiscName.Text.Trim() + "'";
                cmd = new SqlCommand(check, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    messageDisc.Caption = tbDiscName.Text.Trim() + " is existing in store!";
                    messageDisc.Show();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string register = "insert into DISC (DISC_NAME, DISC_AMOUNT,DISC_INSTOCK, DISC_PRICE,DISC_PRODUCER , DISC_GENRE)  values " +
                            "('" + tbDiscName.Text.Trim() + "'," + nbAmount.Value + "," + nbAmount.Value + "," + tbRentPrice.Text + "," +
                            producerID + "," + genreID + ")";
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();

                }

                con.Close();
                LoadDataDisc();
            }
        }

        private bool CheckInputDisc()
        {
            if (tbDiscName.Text == "")
                return false;
            if (cbProducer.Text == "")
                return false;
            if (tbRentPrice.Text == "")
                return false;
            if (cbGenre.Text == "")
                return false;
            return true;
        }

        private int GetGenreID()
        {
            int genreID = 0;
            con.Open();
            string check = "SELECT GENRE_ID FROM GENRE WHERE GENRE_NAME = '" + cbGenre.Text.Trim() + "'";
            cmd = new SqlCommand(check, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    genreID = (int)dr["GENRE_ID"];
                }
                dr.Close();
            }
            con.Close();
            return genreID;
        }

        private int GetProducerID()
        {
            int producerID = 0;
            con.Open();
            string check = "SELECT PRODUCER_ID FROM PRODUCER WHERE PRODUCER_NAME = '" + cbProducer.Text.Trim() + "'";
            cmd = new SqlCommand(check, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    producerID = (int)dr["PRODUCER_ID"];
                }
                dr.Close();
            }
            con.Close();
            return producerID;
        }

        private void gvListDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscIDIm.Text = gvListDisc.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDiscNameIm.Text = gvListDisc.Rows[e.RowIndex].Cells[1].Value.ToString();
            nbInstockIm.Text = gvListDisc.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnImportDisc.Enabled = true;
        }

        private void btnImportDisc_Click(object sender, System.EventArgs e)
        {
            con.Open();
            string register = "update disc set DISC_AMOUNT = DISC_AMOUNT + " + nbAmountIm.Value +
                ", DISC_INSTOCK = DISC_INSTOCK + " + nbAmountIm.Value + "where disc_id = " + tbDiscIDIm.Text.Trim();
            cmd = new SqlCommand(register, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadDataDiscImport();
        }

        private void gvDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscID.Text = gvDisc.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDiscName.Text = gvDisc.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbProducer.SelectedIndex = cbProducer.FindStringExact(gvDisc.Rows[e.RowIndex].Cells[2].Value.ToString());
            cbGenre.SelectedIndex = cbGenre.FindStringExact(gvDisc.Rows[e.RowIndex].Cells[3].Value.ToString());
            tbRentPrice.Text = gvDisc.Rows[e.RowIndex].Cells[5].Value.ToString();
            nbAmount.Text = gvDisc.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdateDisc_Click(object sender, System.EventArgs e)
        {
            if (!CheckInputDisc())
            {

            }
            else
            {
                int genreID = GetGenreID();
                int producerID = GetGenreID();

                con.Open();
                string register = "update DISC set DISC_NAME = '" + tbDiscName.Text.Trim() + "', DISC_AMOUNT = " + nbAmount.Value +
                    ", DISC_PRODUCER = " + producerID + ", DISC_PRICE = " + tbRentPrice.Text + ", DISC_GENRE = " + genreID + " where DISC_ID = " + tbDiscID.Text;
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDataDisc();
            }
        }
    }
}
