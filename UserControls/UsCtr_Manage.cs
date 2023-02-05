using LiveCharts;
using LiveCharts.Wpf;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Manage : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public static DataTable dataTable;
        SqlDataAdapter adapter = new SqlDataAdapter();
        FireBaseConnection fireBaseConnection = new FireBaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtProducer = new DataTable();
        DataTable dtGenre = new DataTable();


        public UsCtr_Manage()
        {
            InitializeComponent();
            btnImportDisc.Enabled = false;
            if (fLogin.permission != "Admin")
            {
                tabControl.TabPages.RemoveByKey("Staff");
            }
            LoadDataStaff();
            LoadDataDisc();
            LoadDataDiscImport();
            LoadDataToComboboxDisc();
            LoadDataToSearchBox();

            cbMode.SelectedIndex = 0;
            cbValues.SelectedIndex = 0;
        }

        private void LoadDataToSearchBox()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            con.Open();
            string loadDT = "select DISC_NAME from DISC";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    auto.Add(reader["DISC_NAME"].ToString());

                }
            }
            tbxDisc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxDisc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxDisc.AutoCompleteCustomSource = auto;

            tbxSearchDisc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxSearchDisc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxSearchDisc.AutoCompleteCustomSource = auto;
            con.Close();

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
            string sql = "select USER_NAME, USER_FULLNAME,USER_ADDRESS, POSITION_NAME from USERS, POSITION where USERS.USER_POSITION = POSITION.POSITION_ID and POSITION_NAME <> 'Customer'";
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
            if (CheckInputDisc() == false)
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
                    con.Close();

                    int discID = 0;
                    con.Open();
                    string loadDT = "select DISC_ID from DISC where DISC_NAME = '" + tbDiscName.Text.Trim() + "'";
                    cmd = new SqlCommand(loadDT, con);
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
                    fireBaseConnection.PushImage(pcDisc, "Disc/" + discID);
                    //fireBaseConnection.RetrieveImage(pcDisc, "Disc/" + tbDiscID);
                    LoadDataDisc();
                }


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

            fireBaseConnection.RetrieveImage(pbDiscIm, "Disc/" + gvListDisc.Rows[e.RowIndex].Cells[0].Value.ToString());

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

            fireBaseConnection.RetrieveImage(pcDisc, "Disc/" + gvDisc.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdateDisc_Click(object sender, System.EventArgs e)
        {
            if (CheckInputDisc() == false)
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

                if (!dr.HasRows)
                {
                    messageDisc.Caption = tbDiscName.Text.Trim() + " is not existing in store!";
                    messageDisc.Show();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string register = "update DISC set DISC_NAME = '" + tbDiscName.Text.Trim() + "', DISC_AMOUNT = " + nbAmount.Value +
                        ", DISC_PRODUCER = " + producerID + ", DISC_PRICE = " + tbRentPrice.Text + ", DISC_GENRE = " + genreID + " where DISC_ID = " + tbDiscID.Text;
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fireBaseConnection.PushImage(pcDisc, "Disc/" + tbDiscID.Text);
                    fireBaseConnection.RetrieveImage(pcDisc, "Disc/" + tbDiscID.Text);
                    LoadDataDisc();
                }
                con.Close();
            }
        }

        private void pcDisc_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose image";
            ofd.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = new Bitmap(ofd.FileName);
                pcDisc.Image = img.GetThumbnailImage(360, 200, null, new IntPtr());
            }
        }

        private void btnCreateChart_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            var values = new ChartValues<int>();
            var dates = new List<string>();
            string get = "select MONTH(return_date) as DATE, sum(RETURN_PRICE) as REVENUE " +
                       "from RETURN_DISC where year(return_date) = " + currentYear + " group by MONTH(return_date)";
            if (cbMode.SelectedIndex == 1)
            {
                get = "select datepart(quarter,return_date) as DATE, sum(RETURN_PRICE) as REVENUE from RETURN_DISC " +
                    "where YEAR( return_date) = " + currentYear + " group by datepart(quarter,return_date)";
            }
            else if (cbMode.SelectedIndex == 2)
            {
                get = "select YEAR(return_date) as DATE, sum(RETURN_PRICE) as REVENUE from RETURN_DISC group by YEAR(return_date)";
            }
            con.Open();
            cmd = new SqlCommand(get, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    values.Add((int)dr["REVENUE"]);
                    dates.Add(dr["DATE"].ToString());
                }
                dr.Close();
            }
            con.Close();
            cartesianChart1.Series.Clear();
            cartesianChart1.Series = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Revenue",
                    Values = values
                },

            };
            cartesianChart1.AxisX.Clear();
            if (cbMode.SelectedIndex == 0)
            {
                cartesianChart1.AxisX.Add(new Axis
                {

                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                });
            }
            else
            {
                cartesianChart1.AxisX.Add(new Axis
                {

                    Labels = dates
                });
            }
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.None;
        }

        private void tbxDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbxDisc.Text != "")
                {
                    con.Open();
                    string sql = "select DISC_ID, DISC_NAME, PRODUCER_NAME, GENRE_NAME, DISC_AMOUNT, DISC_PRICE from DISC, PRODUCER, GENRE " +
                                    "where DISC.DISC_PRODUCER = PRODUCER.PRODUCER_ID and DISC.DISC_GENRE = GENRE.GENRE_ID and DISC_NAME = '" + tbxDisc.Text.Trim() + "'";
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    gvDisc.DataSource = dt;
                }
                else
                {
                    LoadDataDisc();
                }
            }
        }

        private void tbxSearchDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbxSearchDisc.Text != "")
                {
                    con.Open();
                    string sql = "select DISC_ID, DISC_NAME, DISC_INSTOCK, DISC_PRICE from DISC, PRODUCER, GENRE " +
                                    "where DISC.DISC_PRODUCER = PRODUCER.PRODUCER_ID and DISC.DISC_GENRE = GENRE.GENRE_ID and DISC_NAME = '" + tbxSearchDisc.Text.Trim() + "'";
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    gvListDisc.DataSource = dt;
                }
                else
                {
                    LoadDataDiscImport();
                }
            }
        }

        private void tbxSearchDisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbValues.Items.Clear();
            if (cbMode.SelectedIndex == 0)
            {
                lbValues.Text = "Choose month";
                Object[] o = new Object[12];
                for (int i = 0; i < 12; i++)
                {
                    o[i] = i + 1;
                }
                cbValues.Items.AddRange(o);

            }
            else if (cbMode.SelectedIndex == 1)
            {
                lbValues.Text = "Choose quarter";
                Object[] o = new Object[4];
                for (int i = 0; i < 4; i++)
                {
                    o[i] = i + 1;
                }
                cbValues.Items.AddRange(o);
            }
            else
            {
                lbValues.Text = "Choose year";
                Object[] o = new Object[2];
                o[0] = 2022;
                o[1] = 2023;
                cbValues.Items.AddRange(o);
            }
            cbValues.SelectedIndex = 0;

        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            string reportTitle = "REPORT";
            string sql = "select RETURN_DATE, TOTAL_PRICE, USER_FULLNAME from RETURN_DISC,RENT, USERS " +
                "where RETURN_DISC.RENT_ID = RENT.RENT_ID and USERS.USER_ID = RENT.CUSTOMER_ID";
            if (cbMode.SelectedIndex == 0)
            {
                sql += " and month(return_date) = " + cbValues.Text + " and year(return_date) = " + DateTime.Now.Year.ToString();
                reportTitle += " IN MONTH " + cbValues.Text;
            }
            else if (cbMode.SelectedIndex == 1)
            {
                sql += " and datepart(quarter,return_date) = " + cbValues.Text;
                reportTitle += " IN QUARTER " + cbValues.Text + " OF YEAR " + DateTime.Now.Year.ToString();
            }
            else
            {
                sql += " and year(return_date) = = " + cbValues.Text;
                reportTitle += " IN YEAR " + cbValues.Text;
            }
            try
            {
                DataSet ds = new DataSet();
                int i = 0;
                int yPoint = 0;
                string customerName = null;
                string returnDate = null;
                string totalPrice = null;


                con.Open();
                cmd = new SqlCommand(sql, con);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                con.Close();

                yPoint += 20;
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

                graph.DrawString(reportTitle, font, XBrushes.Black, new XRect(0, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
                yPoint += 80;

                graph.DrawString("Customer", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("Date", font, XBrushes.Black, new XRect(320, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("Revenue", font, XBrushes.Black, new XRect(480, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint += 30;

                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    customerName = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    returnDate = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    totalPrice = ds.Tables[0].Rows[i].ItemArray[1].ToString();

                    returnDate = returnDate.Replace(" 12:00:00 AM", "");


                    graph.DrawString(customerName, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(returnDate, font, XBrushes.Black, new XRect(320, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(totalPrice, font, XBrushes.Black, new XRect(480, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    yPoint = yPoint + 40;
                }

                string pdfFilename = "Report.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
            }
        }

        private void tbIDnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbPhonenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbRentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }
    }

}
