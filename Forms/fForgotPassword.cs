using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace OOAD_Project.Forms
{
    public partial class fForgotPassword : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        private string email = "";
        private string password = "";

        public fForgotPassword()
        {
            InitializeComponent();
        }

        private void retriveEmail()
        {
            string username = tbUsername.Text;
            con.Open();
            string loadDT = "select USER_MAIL, USER_PASSWORD from USERS where USER_NAME = '" + username +"'";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    email = (string)reader["USER_MAIL"];
                    password = (string)reader["USER_PASSWORD"];
                }
                reader.Close();
            }
            con.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            retriveEmail();
            if (email != "")
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("discManagementApp@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Forgot Password";
                    mail.IsBodyHtml = true;
                    mail.Body = "Your current password is: " + password;

                    mail.Priority = MailPriority.High;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("discManagementApp@gmail.com", "bgxowptneyoklxgh");
                    SmtpServer.EnableSsl = true;

                    if (email != "")
                    {
                        SmtpServer.Send(mail);
                        lbNotify.Text = "Your current password has been sent to your email!";
                        lbNotify.ForeColor = Color.Green;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                lbNotify.Text = "Username does not exist!";
                lbNotify.ForeColor = Color.Red;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
