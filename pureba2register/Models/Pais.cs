using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class Pais
    {
        [Key]
        public int PaisID { get; set; }

        [Display(Name = "Nombre ddel país")]
        public String NombreDepartamento { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }

    }
}