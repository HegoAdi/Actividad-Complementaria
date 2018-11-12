using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Actividades.Models
{
    public class periodo
    {
        [Key]
        public int idperiodo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        //[StringLength(50,MinimumLength =3, ErrorMessage ="El nombre debe tener 3 a 50 caracteres")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener 3 a 50 caracteres")]
        public string nombre_corto { get; set; }
        
        public string nombre_largo { get; set; }
        
        public DateTime fecha_inicio { get; set; }
        
        public DateTime fecha_fin { get; set; }
        
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener 3 a 50 caracteres")]
        public string estatus { get; set; }
    }
}
