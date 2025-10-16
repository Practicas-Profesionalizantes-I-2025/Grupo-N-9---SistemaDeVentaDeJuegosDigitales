using Microsoft.EntityFrameworkCore;
using TiendaJuegos.Datos.Modelos;

namespace TiendaJuegos.Datos.Contexto
{
    public class AppDbContext : DbContext
    {
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Venta_JuegosOnline;Trusted_Connection=True;");
        }
    }
}
