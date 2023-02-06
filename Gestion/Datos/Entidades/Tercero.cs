using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Datos.Entidades
{

    public class Tercero
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public Nullable<int> TipoTerceroId { get; set; }
        
        [NotMapped]
        public List<TipoTercero> TipoTerceros { get; set; } = new List<TipoTercero>();

        [NotMapped]
        public int? UserId { get; set; }
        
        [NotMapped]
        public List<User> Users { get; set; } = new List<User>();
        
        [NotMapped]
        public List<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
   

    }
}
