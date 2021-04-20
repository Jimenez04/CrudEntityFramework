using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre valido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese un telefono valido")]
        [Display(Name = "Teléfono")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Ingrese un Celular valido")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; }


    }
}
