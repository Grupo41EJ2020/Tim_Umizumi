using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MVCLaboratorio.Models
{
    public class Curso
    {
        [Display(Name="Id Curso")]
        public int IdCurso { get; set; }

        [Display(Name="Descripción")]
        [Required]
        public string Descripcion { get; set; }

        [Display(Name="Id Empleado")]
        public int IdEmpleado { get; set; }

        //Propiedad Adicional
        [Display(Name = "Id Empleado")]        
        public string NombreEmpleado { get; set; }
    }
}