using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Azteca.Models
{
    public class Postulante
    {
        [Required(ErrorMessageResourceName = "Form_name_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_name", ResourceType = typeof(Resources.Resources))]
        public string cv_name { get; set; }

        [Required(ErrorMessageResourceName = "Form_lastname_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_lastname", ResourceType = typeof(Resources.Resources))]
        public string cv_lastname { get; set; }

        [Required(ErrorMessageResourceName = "Form_email_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_email", ResourceType = typeof(Resources.Resources))]
        [EmailAddress(ErrorMessageResourceName = "Form_email_type", ErrorMessageResourceType = typeof(Resources.Resources) , ErrorMessage = null)]
        public string cv_email { get; set; }

        [Required(ErrorMessageResourceName = "Form_dateofbirth_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_dateofbirth", ResourceType = typeof(Resources.Resources))]
        [DataType(DataType.Date, ErrorMessageResourceName = "Form_dateofbirth_type", ErrorMessageResourceType = typeof(Resources.Resources))]
        public DateTime cv_dateofbirth { get; set; }

        [Required(ErrorMessageResourceName = "Form_country_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_country", ResourceType = typeof(Resources.Resources))]
        public string cv_country { get; set; }

        [Required(ErrorMessageResourceName = "Form_city_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_city", ResourceType = typeof(Resources.Resources))]
        public string cv_city { get; set; }

        [Required(ErrorMessageResourceName = "Form_degree_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_degree", ResourceType = typeof(Resources.Resources))]
        public string cv_degree { get; set; }

        public string cv_other { get; set; }

        [Required(ErrorMessageResourceName = "Form_english_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_english", ResourceType = typeof(Resources.Resources))]
        public string cv_english { get; set; }

        [Display(Name = "Form_howto", ResourceType = typeof(Resources.Resources))]
        public string cv_howto { get; set; }

        [Required(ErrorMessageResourceName = "Form_availability_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_availability", ResourceType = typeof(Resources.Resources))]
        public string cv_availability { get; set; }

        [Required(ErrorMessageResourceName = "Form_travel_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_travel", ResourceType = typeof(Resources.Resources))]
        public string cv_travel_disp { get; set; }

        [Display(Name = "Form_jobarea", ResourceType = typeof(Resources.Resources))]
        public string[] cv_job_area { get; set; }

        [Display(Name = "Form_otherinfo", ResourceType = typeof(Resources.Resources))]
        public string cv_otherinfo { get; set; }

        [Required(ErrorMessageResourceName = "Form_salary_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_salary", ResourceType = typeof(Resources.Resources))]
        public string cv_salary { get; set; }

        [Required(ErrorMessageResourceName = "Form_file_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_file", ResourceType = typeof(Resources.Resources))]
        public HttpPostedFileBase cv_file { get; set; }

        [Required(ErrorMessageResourceName = "Form_applyto_req", ErrorMessageResourceType = typeof(Resources.Resources))]
        [Display(Name = "Form_applyto", ResourceType = typeof(Resources.Resources))]
        public string cv_applyto { get; set; }

    }
}