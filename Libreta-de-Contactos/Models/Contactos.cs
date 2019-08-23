using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Libreta_de_Contactos.Models
{
    public class Contactos
    {
        private int contacto;

        [Key]
        public string ContactoId { get; set; }
        [required]
        public string Nombre { get; set; }
        public int Contacto { get => contacto; set => contacto = value; }

        [Display(Description = "Contact Description")]
        [StringLength(30, ErrorMessage = "El contacto debe tener entre 5 y 30 caracteres", MinimumLength = 5)]
        public string TipoContacto { get; set; }
    }
}