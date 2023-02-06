using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Datos.Entidades
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Nombres: ")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; } = "";

        [Required]
        public string Clave { get; set; }

        [NotMapped]
        public List<Tercero> Terceros { get; set; } = new List<Tercero>();

        [NotMapped]
        public List<Producto> Productos { get; set; } = new List<Producto>();

        [NotMapped]
        public List<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
    }
}
