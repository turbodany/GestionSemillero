using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Datos.Entidades
{
    public class Movimiento
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de movimiento")]
        public int? TipoMovimientoId { get; set; }

        [NotMapped]
        public List<TipoMovimiento> TipoMovimientos { get; set; } = new List<TipoMovimiento>();

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime Fecha { get; set; }
        public string Documento { get; set; }

        [Display(Name = "Cliente")]
        public int? TerceroId { get; set; }

        [NotMapped]
        public List<Tercero> Terceros { get; set; } = new List<Tercero>();

        [Display(Name = "Codigo-Producto")]
        public int? ProductoId { get; set; }
        
        [NotMapped]
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public Int32 Cantidad { get; set; }

        [Display(Name = "Valor Unidad")]
        public Int32 ValUnidad { get; set; }

        [Display(Name = "Valor Parcial")]
        public Int32 ValParcial { get; set; }
        public int? UserId { get; set; }

        [NotMapped]
        public List<User> Users { get; set; } = new List<User>();
    }
}
