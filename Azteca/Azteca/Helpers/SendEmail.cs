using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Collections;

namespace Azteca.Helpers
{
    public class SendEmail
    {

        //Definicion de Variables
        MailMessage Message;
        SmtpClient ClienteSmtp;
        Attachment At;
        string User, Password;

        //Metodo Validar Mail
        public bool validarEmail(string Email)
        {
            string Expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(Email, Expresion))
            {
                if (Regex.Replace(Email, Expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }

        //Metodo Configurar Mail
        public void ConfigurarMail(string From, string Usuario, string Contraseña, int Puerto, string Smtp, string body)
        {
            Message = new MailMessage();
            Message.From = new MailAddress(From);
            ClienteSmtp = new SmtpClient(Smtp);
            User = Usuario;
            Password = Contraseña;
            ClienteSmtp.Port = Puerto;
            Message.IsBodyHtml = true;
            Message.Body = body;
        }

        //Metodo Enviar Mail
        public bool EnviarMail(string To, string Cc, string Asunto, string Mensaje, string ruta_archivo_adjunto)
        {

            try
            {

                At = new Attachment(ruta_archivo_adjunto);

                Message.Attachments.Add(At);
                Message.To.Add(To);
                Message.CC.Add(Cc);
                Message.Subject = Asunto;


                //Seguridad Secure Sockets Layer ON
                ClienteSmtp.EnableSsl = true;
                ClienteSmtp.UseDefaultCredentials = false;
                ClienteSmtp.Credentials = new NetworkCredential(User, Password);
                ClienteSmtp.Send(Message);

                return true;

            }
            catch
            {

                try
                {
                    //Seguridad Secure Sockets Layer OFF
                    ClienteSmtp.EnableSsl = false;
                    ClienteSmtp.Send(Message);

                    return true;
                }
                catch
                {
                    return false;
                }

            }

        }

    }
}