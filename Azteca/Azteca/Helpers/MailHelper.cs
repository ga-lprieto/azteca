using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;


namespace Azteca.Helpers
{

    public class MailHelper
    {
        public static void SendMail(string to, string body, string subject) {
            List<string> l = new List<string>();
            l.Add(to);
            SendMail(l, body, subject, null);
        }

        public static void SendMail(string to, string body, string subject, HttpPostedFileBase att) {
            List<string> l = new List<string>();
            l.Add(to);
            SendMail(l, body, subject, att);
        }

        public static void SendMail(IEnumerable<string> to, string body, string subject) {
            SendMail(to, body, subject, null);
        }

        public static void SendMail(IEnumerable<string> to, string body, string subject, HttpPostedFileBase att) {

            using (var m = new SmtpClient())
            {
                var mail = new MailMessage();

                foreach(string address in to)
                {
                mail.To.Add(address);
                }

                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = body;
                if (att != null && att.ContentLength > 0)
                {
                    var attachment = new Attachment(att.InputStream, att.FileName);
                    mail.Attachments.Add(attachment);
                }
                m.Send(mail);

            }
        }

        public static string ParseBody(string country) { 
        
        }
    }
}