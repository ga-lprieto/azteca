using Azteca.Models;
using System.Web.Mvc;
using System.IO;
using Azteca.Helpers;
using System.Collections.Generic;

namespace Azteca.Controllers
{
    public class UploadController : BaseController
    {
        //
        // GET: /Upload/

        public ActionResult Form()
        {

            List<JobArea> l = new List<JobArea>();
            l.Add(new JobArea { name = "Jovenes Profesionales", id = "1" });
            l.Add(new JobArea { name = "Consultoría SAP", id = "2" });
            l.Add(new JobArea { name = "Consultoría Oracle", id = "3" });
            l.Add(new JobArea { name = "Seguridad IT", id = "4" });
            l.Add(new JobArea { name = "Consultoría en Procesos", id = "5" });
            l.Add(new JobArea { name = "Programación", id = "6" });
            l.Add(new JobArea { name = "Administración de Servidores", id = "7" });
            l.Add(new JobArea { name = "RRHH", id = "8" });
            l.Add(new JobArea { name = "Administración", id = "9" });
            l.Add(new JobArea { name = "Marketing", id = "10" });
            l.Add(new JobArea { name = "Legales", id = "11" });
            l.Add(new JobArea { name = "Secretarias / Recepcionistas", id = "12" });
            l.Add(new JobArea { name = "Finanzas", id = "13" });
            ViewBag.jobAreas = l;

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
                

                MailHelper.SendMail("lprieto@grupoassa.com", body, "Test Mail", model.cv_file);

                return this.RedirectToAction("Submit");

            }

            List<JobArea> l = new List<JobArea>();
            l.Add(new JobArea { name = "Jovenes Profesionales" , id = "1"});
            l.Add(new JobArea { name = "Consultoría SAP", id = "2" });
            l.Add(new JobArea { name = "Consultoría Oracle", id = "3" });
            l.Add(new JobArea { name = "Seguridad IT", id = "4" });
            l.Add(new JobArea { name = "Consultoría en Procesos", id = "5" });
            l.Add(new JobArea { name = "Programación", id = "6" });
            l.Add(new JobArea { name = "Administración de Servidores", id = "7" });
            l.Add(new JobArea { name = "RRHH", id = "8" });
            l.Add(new JobArea { name = "Administración", id = "9" });
            l.Add(new JobArea { name = "Marketing", id = "10" });
            l.Add(new JobArea { name = "Legales", id = "11" });
            l.Add(new JobArea { name = "Secretarias / Recepcionistas", id = "12" });
            l.Add(new JobArea { name = "Finanzas", id = "13" });
            ViewBag.jobAreas = l;

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

        
        public ActionResult Submit(string cv_name) {

            return View();
        }

    }
}
