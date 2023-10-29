using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;
using static System.Net.WebRequestMethods;

namespace TpiBarberShop.DBContexts
{
    public class Context : DbContext
    {
        public DbSet<EProducto> Productos { get; set; }
        public DbSet<EPuntos> Puntos { get; set; }
        public DbSet<EUsuarios> Usuarios { get; set; }

        public DbSet<ECompras> Compras { get; set; }
        public DbSet<ECategory> Category { get; set; }

        public DbSet<ESubcategory> SubCategory { get; set; }
        public DbSet<EOrdenCompra> OrdenCompras { get; set; }

        public DbSet<EDetalleCompra> DetalleCompra { get; set; }

        public DbSet<EImagenUsuario> ImagenUsuarios { get; set; }
        public DbSet<EImagenProducto> ImagenProductos { get; set; }





        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var Productos = new EProducto[3]
            {
        new EProducto("Navaja")
        {
            Id = 1,
            Descripcion = "Navaja",
            Stock = 40,
            Precio = 5,
            CategoryId = 2,
            SubcategoryId = 1,
          
        },
        new EProducto("Gel")
        {
            Id = 2,
            Descripcion = "Gel de pelo",
            Stock = 100,
            Precio = 15,
            CategoryId = 1,
            SubcategoryId = 1,
        
        },
        new EProducto("Maquinita")
        {
            Id = 3,
            Descripcion = "Maquinita para cortar",
            Stock = 15,
            Precio = 80,
            CategoryId = 1,
            SubcategoryId = 1,
           
        }
            };

            modelBuilder.Entity<EProducto>().HasData(Productos);


            modelBuilder.Entity<EPuntos>().HasData(
                new EPuntos(3)
                {
                    Id=1,
                    Nombre = "Pepito",
                    ProductoId=1,
                    UsuarioId = 2

                },
                new EPuntos(3)
                {
                    Id = 4,
                    Nombre = "Robert",
                    ProductoId = 1,
                    UsuarioId=7

                },
                new EPuntos(3)
                {
                    Id = 5,
                    Nombre = "Jesus",
                    ProductoId = 1

                },
                new EPuntos(1)
                {
                    Id = 2,
                    Nombre = "Jorge",
                    ProductoId = 2,
                    UsuarioId = 3
                },
                new EPuntos(2)
                {
                    Id = 6,
                    Nombre = "Jorge123",
                    ProductoId = 2,
                    UsuarioId = 4
                },
                new EPuntos(3)
                {
                    Id = 7,
                    Nombre = "perro",
                    ProductoId = 2,
                    UsuarioId = 5
                },
                new EPuntos(5)
                {
                    Id = 3,
                    Nombre = "Juanchon",
                    ProductoId = 3,
                    UsuarioId = 6
                }

                );

            modelBuilder.Entity<EUsuarios>().HasData(
                 new EUsuarios("Jose")
                 {
                     Id = 1,
                     Email = "jose@jose.com",
                     Password = "$2a$11$QBfVcDxBTsNMp/NMGTgAZexNBj/epkt5W1z/GNqP1Blk.d2KoExPm",
                     Role = "Cliente",
                

                     VerificationToken = "adsd",
                     VerifiedAt = DateTime.Now,
                     PasswordResetToken = "adasd",
                     ResetTokenExpires = DateTime.Now,


                 },
                 new EUsuarios("Franco")
                 {
                     Id = 2,
                     Email = "Franco@Franco.com",
                     Password = "$2a$11$QBfVcDxBTsNMp/NMGTgAZexNBj/epkt5W1z/GNqP1Blk.d2KoExPm",
                     Role = "Admin",
                   
                     VerificationToken = "adsd",
                     VerifiedAt = DateTime.Now,
                     PasswordResetToken = "adasd",
                     ResetTokenExpires = DateTime.Now,


                 },
                 new EUsuarios("Pepito")
                 {
                     Id = 3,
                     Email = "Pepito@Pepito.com",
                     Password = "$2a$11$QBfVcDxBTsNMp/NMGTgAZexNBj/epkt5W1z/GNqP1Blk.d2KoExPm",
                     Role = "Cliente",
         
                     VerificationToken = "adsd",
                     VerifiedAt = DateTime.Now,
                     PasswordResetToken = "adasd",
                     ResetTokenExpires = DateTime.Now,




                 }
                 ) ;
            modelBuilder.Entity<ECompras>().HasData(
                new ECompras
                {
                    Id = 1,
                    UsuarioId = 1,
                    ProductoId = 1,
                    Cantidad = 2,
                    Estado = "pendiente",
                    clientePaypalId = "",
                    valorPago = "",
                    pagoId = "",
                    fechaPago= DateTime.Now,
                },
                new ECompras
                {
                    Id = 2,
                    UsuarioId = 2,
                    ProductoId = 2,
                    Cantidad = 4,
                    Estado = "confirmada",
                    clientePaypalId = "132342f",
                    valorPago = "100",
                    pagoId = "123424223",
                    fechaPago = DateTime.Now,
                }
                );
            modelBuilder.Entity<ECategory>().HasData(
               new ECategory("Tijera")
               {
                   Id = 1,
                   Descripcion = "es una tijera"

               },
               new ECategory("Maquinita")
               {
                   Id = 2,
                   Descripcion = "maquinita good"

               }
               );
            modelBuilder.Entity<ESubcategory>().HasData(
               new ESubcategory("Tijeras")
               {
                   Id = 1,
                   CategoryId = 2,

               },
               new ESubcategory("Maquinita")
               {
                   Id = 2,
                   CategoryId = 1

               }
               );

            modelBuilder.Entity<EOrdenCompra>().HasData(
               new EOrdenCompra
               {
                   Id = 1,
                   UsuarioId = 1,
                   Estado = "pendiente",
                   clientePaypalId = "121",
                   valorPago = "121",
                   pagoId = "1",
                   fechaPago = DateTime.Now,



               },
               new EOrdenCompra
               {
                   Id = 2,
                   UsuarioId = 2,
                   Estado = "pendiente",
                   clientePaypalId = "1",
                   valorPago = "233",
                   pagoId = "12",
                   fechaPago = DateTime.Now,

               }
               );
            modelBuilder.Entity<EDetalleCompra>().HasData(
              new EDetalleCompra
              {
                  Id = 1,
                  OrdenCompraId = 1,
                  Cantidad = 3,
                  ProductoId = 1,


              }
            
              );
            modelBuilder.Entity<EImagenUsuario>().HasData(
              new EImagenUsuario
              {
                  Id = 1,
                  UsuarioId= 1,
                  URL="www.usuarioImagen"
              }

             

                

            );
            modelBuilder.Entity<EImagenProducto>().HasData(
             new EImagenProducto
             {
                 Id = 1,
                 ProductoId = 1,
                 URL = "www.produtoImagen"


             }

           );
            base.OnModelCreating(modelBuilder);
        }

       
    }
}
