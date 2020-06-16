using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Models;
using System.Net.Mail;

namespace TestApi.Controllers
{
    public class EmailController : ApiController
    {
        [HttpPost]
        public MailResponse Post(SendEmail mail)
        {
            string to = mail.to;
            string subject = mail.subject;
            string body = mail.body;

            MailMessage main_email = new MailMessage();
            main_email.From = new MailAddress("anegerega@gmail.com");
            main_email.To.Add(to);
            main_email.Subject = subject;
            main_email.Body = body;
            main_email.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = true;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("anegerega@gmail.com", Properties.Settings.Default.EmailPassword); //put correct password here
            smtp.Send(main_email);
            return new MailResponse
            {
                MessageResponse = "Sent Successfully!"
            };
        }
    }
}
