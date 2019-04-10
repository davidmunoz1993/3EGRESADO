using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class InformacionProfesionalEgresado
    {
        [Key]
        public int InformacionProfesionalID { get; set; }

        [Display(Name = "Estudia actualmente?")]
        public Boolean estudiaActualmente { get; set; }

        [Display(Name = "Fecha de terminación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaTerminacionProfesional { get; set; }

        [Display(Name = "Duración")]
        public String duracionProfesional { get; set; }

        public int InformacionPersonalID { get; set; }
        public virtual InformacionPersonal InformacionPersonal { get; set; }

        public int TipoEstudioID { get; set; }
        public virtual TipoEstudio TipoEstudio { get; set; }

        public int CarreraProfesionalID { get; set; }
        public virtual CarreraProfesional CarreraProfesional { get; set; }
    }
}