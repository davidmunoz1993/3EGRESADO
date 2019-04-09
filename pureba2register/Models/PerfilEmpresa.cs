using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class PerfilEmpresa
    {
        [Key]
        public int CrearPerfilEmpresaID { get; set; }
        [Display(Name = "Nmobre Empresa")]
        public string NombreEmpresa { get; set; }
        [Display(Name = "Correo")]
        public char Correo { get; set; }
        [Display(Name = "Nit de la empresa")]
        public int Nit { get; set; }
        [Display(Name = "Dirección empresa")]
        public string DireccionEmpresa { get; set; }
        [Display(Name = "Número de egresados")]
        public int NumeroEgresado { get; set; }
        [Display(Name = "Descripción empresa")]
        public string DescripccionEmpresa { get; set; }

        public char fotoEmpresa { get; set; }
    }
}