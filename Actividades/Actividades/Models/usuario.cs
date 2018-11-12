using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Actividades.Models
{
    public class usuario
    {
        [Key]
        public int idusuario { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        //[StringLength(50,MinimumLength =3, ErrorMessage ="El nombre debe tener 3 a 50 caracteres")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener 3 a 50 caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener 3 a 50 caracteres")]
        public string apellidop { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener 3 a 50 caracteres")]
        public string apellidom { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener 3 a 50 caracteres")]
        public string password { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener 3 a 50 caracteres")]
        public string estatus { get; set; }
    }
}
