using System;
using System.ComponentModel.DataAnnotations;

namespace pureba2register.Models
{
    public class PublicacionesEnEspera
    {
        [Key]

        public int PublicacionEnEspera { get; set; }



        [Display(Name = "Fecha de inicio*")]

        [Required(ErrorMessage = "El campo no puede estar vacío")]

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]

        public DateTime FechaInicio { get; set; }



        [Display(Name = "Fecha de fin*")]

        [Required(ErrorMessage = "El campo no puede estar vacío")]

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]

        public DateTime FechaFinalizacion { get; set; }



        [Display(Name = "Asunto*")]

        [Required(ErrorMessage = "El campo no puede estar vacío")]

        public string Asunto { get; set; }



        [Display(Name = "Información*")]

        [Required(ErrorMessage = "El campo no puede estar vacío")]

        public string Informacion { get; set; }



        [Display(Name = "Estado de la publicación*")]

        [Required(ErrorMessage = "El campo no puede estar vacío")]

        public bool EstadoPublicacion { get; set; }
    }
}