using System.Net.Mail;

namespace OOAD_Project
{
    public class Customer : ICustomer
    {
        private string mailAddress;

        public Customer(IUpcomingDisc upComingdisc, string email)
        {
            mailAddress = email;
            upComingdisc.Attach(this);
        }
        public void Update(string message)
        {
            SendEmail(message);
        }

        private void SendEmail(string message)
        {
            //try
            //{
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("discManagementApp@gmail.com");
            mail.To.Add(mailAddress);
            mail.Subject = message + " is available in our store.";
            mail.IsBodyHtml = true;
            mail.Body = "<p>Dear Customer,<br>" + message + " you subscribed has come. You can go to the store to rent it.<br>Best regards,<br>PQT Store</p>"; ;

            mail.Priority = MailPriority.High;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("discManagementApp@gmail.com", "bgxowptneyoklxgh");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            //}
            //catch (Exception ex)
            //{
            //}

        }
    }
}
