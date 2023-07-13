using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DBContexts
{
    public class Context : DbContext
    {
        public DbSet<EProducto> Productos { get; set; }
        public DbSet<EPuntos> Puntos { get; set; }
        public DbSet<EUsuarios> Usuarios { get; set; }

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
                    Descripcion = "Navaja Filosa",

                },
                new EProducto("Gel")
                {
                    Id = 2,
                    Descripcion = "Gel de pelo",

                },
                new EProducto("Maquinita")
                {
                    Id = 3,
                    Descripcion = "Maquinita para cortar",

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
                     Password = "123",
                     Role = "Cliente"

                 },
                 new EUsuarios("Franco")
                 {
                     Id = 2,
                     Email = "Franco@Franco.com",
                     Password = "123",
                     Role = "Admin"

                 },
                 new EUsuarios("Pepito")
                 {
                     Id = 3,
                     Email = "Pepito@Pepito.com",
                     Password = "123",
                     Role = "Cliente",

                 }
                 );

             base.OnModelCreating(modelBuilder);
        }

       
    }
}
