
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ReservasAereas.Models
{
    public class TiposDocumentos
    {
        [Key]
        public int IdTipoDocumento { get; set; }

        [Display(Name = "Tipos Documentos")]
        [Required(ErrorMessage = "Usted debe ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener  entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DecripcionTipoDocumento { get; set; }

        //lado uno para establecer la relacion de uno a muchos con la clase Usuarios y Tipos de Documentos
       // public virtual ICollection<Usuarios> Usuarios { get; set; }

    }
}
