using System;
using System.Net.Mail;

namespace OOAD_Project
{
    public class Customer : ICustomer
    {
        string mailAddress;
        string mailSubject;
        string mailBody;

        public Customer(string email, string username, string discName)
        {
            mailAddress = email;
            this.mailSubject = discName + " is available in our store.";
            this.mailBody = "Dear " + username + ",\n" + discName + " you subscribed has come. You can go to the store to rent it.\nBest regards,\nPQT Store";
        }
        public void Update(IUpcomingDisc upcomingDisc)
        {
            SendEmail();
        }

        private void SendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("bgxowptneyoklxgh");
                mail.To.Add(mailAddress);
                mail.Subject = mailSubject;
                mail.IsBodyHtml = true;
                mail.Body = mailBody;

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
    }
}
