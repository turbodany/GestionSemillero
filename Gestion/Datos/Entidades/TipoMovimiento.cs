using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Datos.Entidades
{
    public class TipoMovimiento 
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";

        [NotMapped]
        public List<Movimiento> Movimientos { get; set;} = new List<Movimiento>();
    }
}
