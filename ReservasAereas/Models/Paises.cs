
using System.ComponentModel.DataAnnotations;


namespace ReservasAereas.Models
{
    public class Paises
    {

        [Display(Name = "Pais")]
        [Key]
        public int IdPais { set; get; }


        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Usted debe ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener  entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DescripcionPais  { set; get; }
    }
}
