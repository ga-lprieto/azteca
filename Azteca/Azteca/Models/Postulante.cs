﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Azteca.Models
{
    public class Postulante
    {
        [Required]
        [DisplayName("Nombre")]
        public string cv_name { get; set; }

        [Required]
        [DisplayName("Apellido")]
        public string cv_lastname { get; set; }

        [Required]
        [DisplayName("E-Mail")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "It's not a valid E-mail")]
        public string cv_email { get; set; }

        [Required(ErrorMessage = "Birth date cannot be empty")]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime cv_dateofbirth { get; set; }

        [Required]
        [DisplayName("País de Residencia")]
        public string cv_country { get; set; }

        [Required]
        [DisplayName("Ciudad de Residencia")]
        public string cv_city { get; set; }

        [Required]
        [DisplayName("Carrera")]
        public string cv_degree { get; set; }

        public string cv_other { get; set; }

        [Required]
        [DisplayName("Nivel de Inglés")]
        public string cv_english { get; set; }

        [DisplayName("Como nos Encontraste")]
        public string cv_howto { get; set; }

        [Required]
        [DisplayName("Disponibilidad")]
        public string cv_availability { get; set; }

        [Required]
        [DisplayName("Disponibilidad para Viajar")]
        public string cv_travel_disp { get; set; }

        [DisplayName("Áreas de Trabajo")]
        public string[] cv_job_area { get; set; }


        [DisplayName("Otra Información")]
        public string cv_otherinfo { get; set; }

        [Required]
        [DisplayName("Remuneracion Pretendida")]
        public string cv_salary { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [DisplayName("Curriculum Vitae")]
        public HttpPostedFileBase cv_file { get; set; }

        [Required]
        [DisplayName("Postularse a")]
        public string cv_applyto { get; set; }

    }
}