using Azteca.Models;
using System.Web.Mvc;
using System.IO;
using Azteca.Helpers;
using System.Collections.Generic;
using System.Globalization;

namespace Azteca.Controllers
{
    public class UploadController : BaseController
    {
        //
        // GET: /Upload/

        public ActionResult Form()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Form(Postulante model)
        {
            //MODEL IS VALID
            if (ModelState.IsValid)
            {
                string subject = string.Empty;
                if (model.cv_job_area != null)
                {
                    subject = model.cv_job_area[0]+" - ";
                    subject += model.cv_salary;
                    subject += (model.cv_applyto.Equals("OTHER")) ? " (MULTIPLE)" : "";
                } 
                    else
	            {
                    subject = "No Job Area - ";
                    subject += model.cv_salary;
                    subject += (model.cv_applyto.Equals("OTHER")) ? " (MULTIPLE)" : "";
	            }

                string body = ParseBody(model);


                MailHelper.SendMail(CountryHelper.getAddress(model.cv_applyto), body, subject, model.cv_file);

                return this.RedirectToAction("Submit","Upload",model.cv_name);

            }

            //INVALID MODEL
            return View(model);
        }

        
        public ActionResult Submit(string cv_name) {
            
            ViewBag.cv_name = cv_name;

            return View();
        }

        public string ParseBody(Postulante model)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(Server.MapPath("~/Templates/emailTemplate_" + CountryHelper.getLangForCountry(model.cv_applyto) + ".html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{cv_name}", model.cv_name);
            body = body.Replace("{cv_lastname}", model.cv_lastname);
            body = body.Replace("{cv_dateofbirth}", model.cv_dateofbirth.Day + "/" + model.cv_dateofbirth.Month + "/" + model.cv_dateofbirth.Year);
            body = body.Replace("{cv_email}", model.cv_email);
            body = body.Replace("{cv_country}", model.cv_country);
            body = body.Replace("{cv_city}", model.cv_city);
            body = body.Replace("{cv_degree}", model.cv_degree);
            body = body.Replace("{cv_english}", model.cv_english);
            body = body.Replace("{cv_howto}", model.cv_howto);
            body = body.Replace("{cv_availability}", model.cv_availability);

            if (model.cv_job_area != null)
            {
                string fillUp = "";

                fillUp += "<ol>";

                for (int i = 0; i < model.cv_job_area.Length; i++)
                {
                    fillUp += "<li>" + model.cv_job_area[i] + "</li>";
                }

                fillUp += "</ol>";

                body = body.Replace("{cv_job_area}", fillUp);

            }
            else
            {
                body = body.Replace("{cv_job_area}", "");
            }

            string travel_disp;
            if (bool.Parse(model.cv_travel_disp))
            {
                travel_disp = "Si";
            }
            else
            {
                travel_disp = "No";
            }
            body = body.Replace("{cv_travel_disp}", travel_disp);
            body = body.Replace("{cv_otherinfo}", model.cv_otherinfo);
            body = body.Replace("{cv_salary}", model.cv_salary);

            return body;
        }


    }
}
