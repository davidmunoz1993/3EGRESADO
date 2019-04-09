using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class TipoEstudio
    {
        [Key]
        public int TipoEstudioID { get; set; }

        [Display(Name = "Tipo de estudio")]
        public String NombreTipoEstudio { get; set; }

        public virtual ICollection<InformacionProfesional> InformacionProfesionals { get; set; }

    }
}