using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
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

            message.Caption = "Success";
            message.Show();
            string mailAddress = "";
            con.Open();
            loadDT = "select USER_MAIL from rent, users where RENT.CUSTOMER_ID = USERS.USER_ID and RENT_ID = " + tbID.Text;
            cmd = new SqlCommand(loadDT, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mailAddress = (string)reader["USER_MAIL"];
                }
                reader.Close();
            }
            con.Close();

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("discManagementApp@gmail.com");
                mail.To.Add(mailAddress);
                mail.Subject = "Your orders in PQT store are ready";
                mail.IsBodyHtml = true;
                mail.Body = GetMailBody();

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("discManagementApp@gmail.com", "bgxowptneyoklxgh");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
            }
        }

        private string GetMailBody()
        {
            try
            {
                string messageBody = "<font>Please check your rental detail below: </font><br>";
                messageBody += "<font>Order ID: " + tbID.Text + "</font><br>";
                messageBody += "<font>Rent date: " + tbRentdate.Text + "</font><br>";
                messageBody += "<font>Due date: " + tbDuedate.Text + "</font><br>";
                messageBody += "<font>Rent price: " + lbRent.Text + "</font><br>";
                messageBody += "<font>Deposit: " + lbDeposit.Text + "</font><br><br>";

                if (gvOrder.RowCount == 0) return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style=\"background-color:#396EB0; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style=\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#396EB0; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";
                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                messageBody += htmlTdStart + "Disc name" + htmlTdEnd;
                messageBody += htmlTdStart + "Price/day" + htmlTdEnd;
                messageBody += htmlTdStart + "Amount" + htmlTdEnd;
                messageBody += htmlTdStart + "Total" + htmlTdEnd;
                messageBody += htmlHeaderRowEnd;
                for (int i = 0; i <= gvOrder.RowCount - 1; i++)
                {
                    messageBody = messageBody + htmlTrStart;
                    messageBody = messageBody + htmlTdStart + gvOrder.Rows[i].Cells[0].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + gvOrder.Rows[i].Cells[2].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + gvOrder.Rows[i].Cells[1].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + (int)gvOrder.Rows[i].Cells[1].Value * (int)gvOrder.Rows[i].Cells[2].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTrEnd;
                }
                messageBody = messageBody + htmlTableEnd;
                return messageBody; // return HTML Table as string from this function
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
