using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Facturando_2.Models;

namespace Facturando_2.DatosBD
{
    public class contextoDB:DbContext
    {
        public contextoDB(DbContextOptions<contextoDB> options):base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaProducto> FacturaProductos { get; set; }
        public DbSet<FacturaCliente> FacturaClientes { get; set; }
        public DbSet<FacturaUsuario> FacturaUsuarios { get; set; }
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacturaCliente>()
                .HasKey(fc => new { fc.FacturasId, fc.ClientesId });
            modelBuilder.Entity<FacturaCliente>()
                .HasOne(c => c.FacturasC)
                .WithMany(fc => fc.FacturaClientes)
                .HasForeignKey(c => c.FacturasId);
            modelBuilder.Entity<FacturaCliente>()
                .HasOne(c => c.ClientesF)
                .WithMany(fc => fc.FacturaClientes)
                .HasForeignKey(c => c.ClientesId);

            modelBuilder.Entity<FacturaUsuario>()
                .HasKey(fu => new { fu.FacturasId, fu.UsuariosId });
            modelBuilder.Entity<FacturaUsuario>()
                .HasOne(u => u.FacturasU)
                .WithMany(fu => fu.FacturaUsuarios)
                .HasForeignKey(u => u.FacturasId);
            modelBuilder.Entity<FacturaUsuario>()
                .HasOne(u => u.UsuarioF)
                .WithMany(fu => fu.FacturaUsuarios)
                .HasForeignKey(u => u.UsuariosId);

            modelBuilder.Entity<FacturaProducto>()
                .HasKey(pro => new { pro.FacturasId, pro.ProductoId });
            modelBuilder.Entity<FacturaProducto>()
                .HasOne(u => u.FacturasP)
                .WithMany(pro => pro.FacturaProductos)
                .HasForeignKey(c => c.FacturasId);
            modelBuilder.Entity<FacturaProducto>()
                .HasOne(u => u.ProductoF)
                .WithMany(pro => pro.FacturaProductos)
                .HasForeignKey(u => u.ProductoId);
        }
    }
}
