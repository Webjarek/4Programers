using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using EmailService.Domain;

namespace EmailService.Infrastructure
{
    public class EmailService : IEmailService
    {
        private string _email;
        private string _pass;

        public EmailService()
        {
            _email = "***@gmail.com";
            _pass = "***";
        }

        public void Send(string context,string toEmail)
        {
            SmtpClient client = new SmtpClient();
            MailMessage msg = new MailMessage();

            msg.To.Add(toEmail);
            msg.From = new MailAddress(_email, "Code Executable", Encoding.UTF8);
            msg.Subject = Environment.UserName;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = context;

            client.Credentials = new NetworkCredential(_email, _pass);
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            //etc    
        }
    }
}
