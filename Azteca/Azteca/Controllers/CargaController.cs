using Azteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azteca.Controllers
{
    public class CargaController : Controller
    {
        //
        // GET: /Carga/

        public ActionResult Form()
        {
            return View();
        }


        [AcceptVerbs("POST")]
        public ActionResult Submit(Postulante model)
        {
            if (ModelState.IsValid)
            {
                //send mail
                ViewBag.cv_name = model.cv_name;
                return View();

            }
            return View("form",model);
        }


    }
}
