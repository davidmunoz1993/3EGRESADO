using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class ReferenciasPersonalesEgresado
    {   [Key]
        [Display(Name = " Id referencias")]
        public int referenciasPersonalesID { get; set; }

        [Display(Name = "Nombres")]
        public String nombresReferencia { get; set; }

        [Display(Name = "Primer apeliido")]
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Solo se aceptan letras en este campo")]
        public String primerApellidoReferencia { get; set; }

        [Display(Name = " Segundo apellido")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Solo se aceptan letras en este campo")]
        public String segundoApellidoReferencia { get; set; }

        [Display(Name = "Cargo que ocupa")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Solo se aceptan letras en este campo")]
        public String cargoReferencia { get; set; }

        [Display(Name = "Teléfono ")]
        public String telefonoFijoReferencia { get; set; }

        [Display(Name = "Extención")]
        public String extTelefonoReferencia { get; set; }

        [Display(Name = "Teléfono móvil")]
        public String telefonoMovilReferencia { get; set; }

        public int InformacionPersonalID { get; set; }
        public virtual InformacionPersonal InformacionPersonal { get; set; }

        public int ParentescoID { get; set; }
        public virtual Parentesco Parentesco { get; set; }

        public int TipoReferenciaID { get; set; }
        public virtual TipoReferencia TipoReferencia { get; set; }
    }
}