using Gestion.Datos.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Datos
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }
        public DbSet<Existencia> Existencias { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Producto> Productos { get; set; } //para mapear las entidades, creo la propiedad de tipo Dbset
        public DbSet<Tercero> Terceros { get; set; }
        public DbSet<TipoMovimiento> TipoMovimientos { get; set; } 
        public DbSet<TipoTercero> TipoTerceros { get; set; } 
        public DbSet<User> Users { get; set; } 
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Producto>().HasIndex(p => p.Name).IsUnique(); // agrego un indice para que el nombre del producto no se repita
            //modelBuilder.Entity<Tercero>().HasIndex(p => p.Nombre).IsUnique();
            //modelBuilder.Entity<TipoMovimiento>().HasIndex("Nombre","MovimientoId").IsUnique();
            //modelBuilder.Entity<TipoTercero>().HasIndex("Nombre","TerceroId").IsUnique();
            //modelBuilder.Entity<Existencia>().HasIndex("Id","ProductoId").IsUnique();
            //modelBuilder.Entity<Tercero>().HasIndex("Nombre","MovimientoId").IsUnique();
        }
      
    } 
}
