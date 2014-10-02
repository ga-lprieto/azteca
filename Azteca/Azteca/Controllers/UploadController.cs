using Azteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            string[] noYes = { "Yes", "No" };
            ViewBag.yesNo = new SelectList(noYes);
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
                //send mail
                ViewBag.cv_name = model.cv_name;
                return this.RedirectToAction("Submit");

            }

            string[] availability = { "Full Time", "Part Time (6 horas)" };
            string[] howto = { "Publicidad", "Reporte de Analistas", "Artículos o Noticias", "Eventos", "Empleado de Grupo Assa", "Recomendación", "WebLinks", "Búsqueda en Internet", "Redes Sociales", "Otros" };
            string[] english = { "Basic", "Intermediate", "Advanced" };
            string[] carrers = { "Ingenieria", "Administracion", "Otra" };
            string[] countries = { "Argentina", "Brasil", "Mexico" };
            string[] noYes = { "Yes", "No" };
            ViewBag.yesNo = new SelectList(noYes);
            ViewBag.countryList = new SelectList(countries);
            ViewBag.carrerList = new SelectList(carrers);
            ViewBag.englishList = new SelectList(english);
            ViewBag.howtoList = new SelectList(howto);
            ViewBag.availabilityList = new SelectList(availability);

            return View(model);
        }

        public ActionResult Submit() {
            return View();
        }

    }
}
