using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class CarreraProfesionalEgresado
    {
        [Key]
        public int CarreraProfesionalID { get; set; }

        [Display(Name = "Tipo de estudio")]
        public String NombreCarrera { get; set; }

        [Display(Name = "Descripción de la carrera")]
        public String DescripcionCarrera { get; set; }

    }
}