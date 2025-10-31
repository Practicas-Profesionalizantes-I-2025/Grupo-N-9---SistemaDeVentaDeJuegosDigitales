using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClasesTienda.modelo;


namespace ClasesTienda.data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Envio> Envios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public  DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public  DbSet<FormaPago> FormasPago { get; set; }
        public DbSet<PedidoProducto> PedidoProductos { get; set; }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TPpractica;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        
    }
}
