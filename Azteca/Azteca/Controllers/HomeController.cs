using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azteca.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutGA()
        {
            return View();
        }

        public ActionResult Locations()
        {
            return View();
        }

        public ActionResult GAPolicies()
        {
            return View();
        }
    }
}
