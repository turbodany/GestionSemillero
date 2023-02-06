using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Datos.Entidades
{
    public class TipoTercero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        [NotMapped]
        public List<Tercero> Terceros { get; set; } = new List<Tercero>();
    }
}
