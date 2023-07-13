using TpiBarberShop.DTOs;


namespace TpiBarberShop
{
    public class ProductosData
    {
        public List<ProductoDTO> Productos { get; set; }

        //public static ProductosData InstanciaUnica { get; } = new ProductosData(); 

        public ProductosData()
        {
            Productos = new List<ProductoDTO>
            {
                new ProductoDTO() 
                {
                    Id = 1,
                    Nombre = "Tijera",
                    Descripcion = "Tijera Filosa",
                    Puntos = new List<PuntosDTO>
                    {
                        new PuntosDTO()
                        {
                            Id= 1,
                            Puntos= 5,
                            Nombre = "Jorge"
                        }
                    }
                
                },
                new ProductoDTO()
                {
                    Id = 2,
                    Nombre = "Maquinita",
                    Descripcion = "Maquinita electrica",
                    Puntos = new List<PuntosDTO>
                    {
                        new PuntosDTO()
                        {
                            Id = 2,
                            Puntos = 3,
                            Nombre = "Pachu"
                        }
                    }
                },
                new ProductoDTO()
                {
                    Id = 3,
                    Nombre = "Gel",
                    Descripcion = "Gel para el pelo",
                    Puntos = new List<PuntosDTO>
                    {
                        new PuntosDTO()
                        {
                            Id= 3,
                            Puntos= 2,
                            Nombre = "Jorgito"
                        }
                    }
                },
            };
        }
    }
}
