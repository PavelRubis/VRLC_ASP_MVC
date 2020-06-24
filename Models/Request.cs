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
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("rubisiay@gmail.com", "Pavel");
            // кому отправляем
            MailAddress to = new MailAddress("edkun@yandex.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Заявка на юр. консультацию";
            // текст письма
            m.Body = $"Имя:{this.Name}\n\n Номер телефона:{this.Phone}\n\n Email:{this.Phone}\n\n\n Сообщение:\n{this.Msg}";
            // письмо представляет код html
            m.IsBodyHtml = false;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("rubisiay@gmail.com", ",jhtwDjdfVjkjltw2011");
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