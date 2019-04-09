using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class Parentesco
    {
        [Key]
        public int ParentescoID { get; set; }

        [Display(Name = "Tipo de parentesco ")]
        public String TipoParentesco { get; set; }

        public virtual ICollection<ReferenciasPersonales> ReferenciasPersonales { get; set; }

    }
}