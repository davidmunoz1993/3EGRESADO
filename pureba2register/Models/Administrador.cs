using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class Administrador
    { [Key]
     public int AdministradorID { get; set; }
        [Display(Name = "Nombre*")]

        [Required(ErrorMessage = "El campo nombre no puede estar vacío")]

        public string Nombre { get; set; }



        [Display(Name = "Primer apellido*")]

        [Required(ErrorMessage = "El campo primer apellido no puede estar vacío")]

        public string PrimerApellido { get; set; }



        [Display(Name = "Segundo apellido")]

        public string SegundoApellido { get; set; }



        [Display(Name = "Dirección*")]

        [Required(ErrorMessage = "El campo dirección no puede estar vacío")]

        public string Direccion { get; set; }



        [Display(Name = "Teléfono fijo")]

        public string TelefonoFijo { get; set; }



        [Display(Name = "Teléfono movil*")]

        [Required(ErrorMessage = "El campo teléfono móvil no puede estar vacío")]

        public string TelefonoMovil { get; set; }



        [Display(Name = "Número de documento*")]

        [Required(ErrorMessage = "El campo documento no puede estar vacío")]

        public string NumeroDocumento { get; set; }



      
    }
}