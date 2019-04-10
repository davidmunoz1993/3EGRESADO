using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class InfromacionLaboralEgresado
    {

        [Key]
        public int InformacionLaboralID { get; set; }

        [Display(Name = "Trabaja actualmente?")]
        public Boolean trabajaActualmente { get; set; }

        [Display(Name = "Jefe inmediato - Nombres")]
        public String nombresJefeLaboral { get; set; }

        [Display(Name = "Jefe inmediato- Apellido")]
        [Required]
        public String apellidoJefeLaboral { get; set; }

        [Display(Name = "Jefe inmediato- Teléfono")]
        [Required]
        public String telefonoJefeLaboral { get; set; }

        [Display(Name = "Nombre de la empresa")]
        public String nombreEmpresaLaboral { get; set; }

        [Display(Name = "Dirección de la empresa")]
        public String direccionEmpresaLaboral { get; set; }

        [Display(Name = "Cargo ocupación laboral")]
        public String cargoOcupacionLaboral { get; set; }

        [Display(Name = "Fecha de ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaIngresoLaboral { get; set; }

        public int InformacionPersonalID { get; set; }
        public virtual InformacionPersonal InformacionPersonal { get; set; }

        public int RangoSalarialID { get; set; }
        public virtual RangoSalarial RangoSalarial { get; set; }
    }
}