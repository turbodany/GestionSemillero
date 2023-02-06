using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Datos.Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de producto")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Precio de Compra")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Int32 PriceBuy { get; set; }

        [Display(Name = "Precio de Venta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Int32 PriceSale { get; set; }

        public int? UserId { get; set; }
        
        [NotMapped]
        public List<User> Users { get; set; }= new List<User>();

        [NotMapped]
        public List<Movimiento> Movimientos { get; set; }= new List<Movimiento>();
        [NotMapped]
        public List<Existencia> Existencias { get; set; }= new List<Existencia>();

    }
}
