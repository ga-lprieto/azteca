using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Azteca.Models
{
    public class Postulante
    {
        [Required(ErrorMessage = "Name cannot be empty")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string cv_name { get; set; }

        [Required(ErrorMessage = "Last Name cannot be empty")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string cv_lastname { get; set; }

        [Required(ErrorMessage = "Last Name cannot be empty")]
        [EmailAddress(ErrorMessage = "It's not a valid E-mail")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string cv_email { get; set; }

        [Required(ErrorMessage = "Birth date cannot be empty")]
        public DateTime cv_dateofbirth { get; set; }

        public string cv_country { get; set; }

        public string cv_city { get; set; }

        public string cv_degree { get; set; }

        public string cv_english { get; set; }

        public string cv_howto { get; set; }

        public string cv_availability { get; set; }

        public string cv_travel_disp { get; set; }

        public string[] cv_jobareas { get; set; }

        public string cv_otherinfo { get; set; }

        public string cv_salary { get; set; }

        public HttpPostedFileBase cv_file { get; set; }
    }
}