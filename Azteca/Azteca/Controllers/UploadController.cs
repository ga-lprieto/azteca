using Azteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Azteca.Helpers;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Web.Configuration;
using System.Configuration;
using System.Net.Configuration;
using System.Web.Helpers;

namespace Azteca.Controllers
{
    public class UploadController : Controller
    {
        //
        // GET: /Upload/

        public ActionResult Form()
        {
            string[] availability = { "Full Time", "Part Time (6 horas)" };
            string[] howto = { "Publicidad", "Reporte de Analistas", "Artículos o Noticias", "Eventos", "Empleado de Grupo Assa", "Recomendación", "WebLinks", "Búsqueda en Internet", "Redes Sociales", "Otros" };
            string[] english = { "Basic", "Intermediate", "Advanced" };
            string[] carrers = { "Ingenieria", "Administracion", "Otra" };
            string[] countries = { "Argentina", "Brasil", "Mexico" };
            ViewBag.countryList = new SelectList(countries);
            ViewBag.carrerList = new SelectList(carrers);
            ViewBag.englishList = new SelectList(english);
            ViewBag.howtoList = new SelectList(howto);
            ViewBag.availabilityList = new SelectList(availability);
            return View();
        }


        [HttpPost]
        public ActionResult Form(Postulante model)
        {
            if (ModelState.IsValid)
            {
                return this.RedirectToAction("Submit",model);

            }

            string[] availability = { "Full Time", "Part Time (6 horas)" };
            string[] howto = { "Publicidad", "Reporte de Analistas", "Artículos o Noticias", "Eventos", "Empleado de Grupo Assa", "Recomendación", "WebLinks", "Búsqueda en Internet", "Redes Sociales", "Otros" };
            string[] english = { "Basic", "Intermediate", "Advanced" };
            string[] carrers = { "Ingenieria", "Administracion", "Otra" };
            string[] countries = { "Argentina", "Brasil", "Mexico" };
            ViewBag.countryList = new SelectList(countries);
            ViewBag.carrerList = new SelectList(carrers);
            ViewBag.englishList = new SelectList(english);
            ViewBag.howtoList = new SelectList(howto);
            ViewBag.availabilityList = new SelectList(availability);

            return View(model);
        }

        public ActionResult Submit(Postulante model) {

            string body = string.Empty;
            using (StreamReader reader = new StreamReader(Server.MapPath("~/Templates/emailTemplate.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{cv_name}", model.cv_name);
            body = body.Replace("{cv_lastname}", model.cv_lastname);
            body = body.Replace("{cv_dateofbirth}", model.cv_dateofbirth.Day+"/"+model.cv_dateofbirth.Month+"/"+model.cv_dateofbirth.Year );
            body = body.Replace("{cv_email}", model.cv_email);
            body = body.Replace("{cv_country}", model.cv_country);
            body = body.Replace("{cv_city}", model.cv_city);
            body = body.Replace("{cv_degree}", model.cv_degree);
            body = body.Replace("{cv_english}", model.cv_english);
            body = body.Replace("{cv_howto}", model.cv_howto);
            body = body.Replace("{cv_availability}", model.cv_availability);
            body = body.Replace("{cv_travel_disp}", model.cv_travel_disp);
            body = body.Replace("{cv_otherinfo}", model.cv_otherinfo);
            body = body.Replace("{cv_salary}", model.cv_salary);


            //Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
            //MailSettingsSectionGroup settings = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");


            //WebMail.SmtpServer = settings.Smtp.Network.Host;
            //WebMail.SmtpPort = settings.Smtp.Network.Port;
            //WebMail.From = settings.Smtp.From;
            //WebMail.Password = settings.Smtp.Network.Password;
            //WebMail.SmtpUseDefaultCredentials = settings.Smtp.Network.DefaultCredentials;
            //WebMail.Send("lprieto@grupoassa.com","TEST",body,WebMail.From,null,null,true);


            using (var m = new SmtpClient()) {
                var mail = new MailMessage();
                mail.To.Add("lprieto@grupoassa.com");
                mail.Subject = "Test mail";
                mail.IsBodyHtml = true;
                mail.Body = body;
                if (model.cv_file != null && model.cv_file.ContentLength > 0)
                {
                    var attachment = new Attachment(model.cv_file.InputStream, model.cv_file.FileName);
                    mail.Attachments.Add(attachment);
                }
                m.Send(mail);

            }

            ViewBag.cv_name = model.cv_name;

            return View();
        }

    }
}
