// <auto-generated />
using System;
using Facturando_2.DatosBD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Facturando_2.Migrations
{
    [DbContext(typeof(contextoDB))]
    [Migration("20220127235134_migracionDos")]
    partial class migracionDos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Facturando_2.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("FacturaIdFactura")
                        .HasColumnType("int");

                    b.Property<string>("NombreCli")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCliente");

                    b.HasIndex("FacturaIdFactura");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Facturando_2.Models.Factura", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClienteF")
                        .HasColumnType("int");

                    b.Property<int>("IdFactutaF")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotal")
                        .HasMaxLength(50)
                        .HasColumnType("real");

                    b.HasKey("IdFactura");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Facturando_2.Models.FacturaCliente", b =>
                {
                    b.Property<int>("FacturasId")
                        .HasColumnType("int");

                    b.Property<int>("ClientesId")
                        .HasColumnType("int");

                    b.HasKey("FacturasId", "ClientesId");

                    b.HasIndex("ClientesId");

                    b.ToTable("FacturaClientes");
                });

            modelBuilder.Entity("Facturando_2.Models.FacturaProducto", b =>
                {
                    b.Property<int>("FacturasId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("FacturasId", "ProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("FacturaProductos");
                });

            modelBuilder.Entity("Facturando_2.Models.FacturaUsuario", b =>
                {
                    b.Property<int>("FacturasId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("FacturasId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("FacturaUsuarios");
                });

            modelBuilder.Entity("Facturando_2.Models.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Facturando_2.Models.Usuario", b =>
                {
                    b.Property<int>("IdFacturador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int?>("FacturaIdFactura")
                        .HasColumnType("int");

                    b.Property<string>("NombreFac")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdFacturador");

                    b.HasIndex("FacturaIdFactura");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Facturando_2.Models.Cliente", b =>
                {
                    b.HasOne("Facturando_2.Models.Factura", null)
                        .WithMany("Clientes")
                        .HasForeignKey("FacturaIdFactura");
                });

            modelBuilder.Entity("Facturando_2.Models.FacturaCliente", b =>
                {
                    b.HasOne("Facturando_2.Models.Cliente", "ClientesF")
                        .WithMany("FacturaClientes")
                        .HasForeignKey("ClientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturando_2.Models.Factura", "FacturasC")
                        .WithMany("FacturaClientes")
                        .HasForeignKey("FacturasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientesF");

                    b.Navigation("FacturasC");
                });

            modelBuilder.Entity("Facturando_2.Models.FacturaProducto", b =>
                {
                    b.HasOne("Facturando_2.Models.Factura", "FacturasP")
                        .WithMany("FacturaProductos")
                        .HasForeignKey("FacturasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturando_2.Models.Producto", "ProductoF")
                        .WithMany("FacturaProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturasP");

                    b.Navigation("ProductoF");
                });

            modelBuilder.Entity("Facturando_2.Models.FacturaUsuario", b =>
                {
                    b.HasOne("Facturando_2.Models.Factura", "FacturasU")
                        .WithMany("FacturaUsuarios")
                        .HasForeignKey("FacturasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturando_2.Models.Usuario", "UsuarioF")
                        .WithMany("FacturaUsuarios")
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturasU");

                    b.Navigation("UsuarioF");
                });

            modelBuilder.Entity("Facturando_2.Models.Usuario", b =>
                {
                    b.HasOne("Facturando_2.Models.Factura", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("FacturaIdFactura");
                });

            modelBuilder.Entity("Facturando_2.Models.Cliente", b =>
                {
                    b.Navigation("FacturaClientes");
                });

            modelBuilder.Entity("Facturando_2.Models.Factura", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("FacturaClientes");

                    b.Navigation("FacturaProductos");

                    b.Navigation("FacturaUsuarios");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Facturando_2.Models.Producto", b =>
                {
                    b.Navigation("FacturaProductos");
                });

            modelBuilder.Entity("Facturando_2.Models.Usuario", b =>
                {
                    b.Navigation("FacturaUsuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
