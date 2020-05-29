using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MVCLaboratorio.Models
{
    public class Curso_Tema_Video
    {
        [Display(Name = "Id CTV")]
        public int IdCTV { get; set; }

        [Display(Name = "Id CT")]
        public int IdCT { get; set; }

        [Display(Name = "Id Video")]
        public int IdVideo{ get; set; }

        [Display(Name = "Id Video")]
        public string NombreVideo { get; set; }
    }
}