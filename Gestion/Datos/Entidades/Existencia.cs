using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Gestion.Datos.Entidades
{
    public class Existencia
    {
        public int Id { get; set; }
        public long CEntra { get; set; }
        public long CSale { get; set; }
        public long Saldo { get; set; }

        [NotMapped]
        public List<Producto> Productos { get; set; }
    }
}
