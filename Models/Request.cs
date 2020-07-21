using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace WebSiteASP.Models
{
    public class Request
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Msg { get; set; }

        public bool SendRequest()
        {
            MailAddress from = new MailAddress("sender@gmail.com", "Pavel");

            MailAddress to = new MailAddress("receiver@gmail.com");

            MailMessage m = new MailMessage(from, to);

            m.Subject = "Заявка на юр. консультацию";

            m.Body = $"Имя:{this.Name}\n\n Номер телефона:{this.Phone}\n\n Email:{this.Phone}\n\n\n Сообщение:\n{this.Msg}";

            m.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("sender@gmail.com", "password");
            smtp.EnableSsl = true;
            try
            {
                throw new Exception();
                //smtp.Send(m);
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
    }
}