
using System.ComponentModel.DataAnnotations;

namespace ReservasAereas.Models
{
    public class Departamentos
    {
        [Key]
        public int IdDepartamento { get; set; }

        [Display(Name = "Departamentos")]
        [Required(ErrorMessage = "Usted debe ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener  entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DescripcionDepartamento { set; get; }

        //inicio
        //para crear la relacion lado varios entre DocumentType y Employee
        //campo en la tabla employee que se realaciona con la tabla DocumentType
        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Usted debe ingresar {0}")]
        public int IdPais { get; set; }
        //indica que la tabla empleados se realizaciona con la tabla tipo de documento DocumentType uno a mucho.

        [Display(Name = "Pais")]
        public virtual Paises Paises { get; set; }
        //Fin crear relacion
    }
}
