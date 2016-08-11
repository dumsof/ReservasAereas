
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ReservasAereas.Models
{
    public class ReservaAereaContext : DbContext
    {
        public ReservaAereaContext() : base("name=conexionReservaAerea")
        {
        }

        //deshabilitar el borrado en cascada
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Paises> Products { get; set; }

        public DbSet<Departamentos> Departamentos { get; set; }

        public DbSet<TiposDocumentos> TiposDocumentos { get; set; }

        
    }
}