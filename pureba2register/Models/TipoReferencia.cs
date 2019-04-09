using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class TipoReferencia
    {
        [Key]
        public int TipoReferenciaID { get; set; }

        [Display(Name = "Tipo de referencia")]
        public String NombreTipoReferencia { get; set; }

        public virtual ICollection<ReferenciasPersonales> ReferenciasPersonales { get; set; }

    }
}