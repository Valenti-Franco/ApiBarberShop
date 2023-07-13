using TpiBarberShop.DTOs;


namespace TpiBarberShop.Data
{
    public class UsuariosData
    {
        public List<UsuariosDTO> Usuarios { get; set; }

        public static UsuariosData InstanciaUnica { get; } = new UsuariosData(); // cada q arranca el programa, se corre y se instancia ProductosData

        public UsuariosData()
        {
            Usuarios = new List<UsuariosDTO>
            {
                new UsuariosDTO()
                {
                    Id = 1,
                    Nombre = "Jorge",
                    Email = "jorge@gmail.com",
                    Role = "Cliente"

                },
                new UsuariosDTO()
                {
                    Id = 2,
                    Nombre = "Fran",
                    Email = "franco@gmail.com",
                    Role = "Admin"

                },
                new UsuariosDTO()
                {
                    Id = 3,
                    Nombre = "Pedro",
                    Email = "lol@gmail.com",
                    Role = "Cliente"

                },
            };
        }
    }
}
