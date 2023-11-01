using TpiBarberShop.DTOs.Imagen;
using TpiBarberShop.DTOs.Punto;

namespace TpiBarberShop.DTOs.Producto
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Precio { get; set; }
        public int CategoryId { get; set; }


        public int SubcategoryId { get; set; }
        public IList<PuntosFilterDTO> Puntos { get; set; }

        public int Stock { get; set; }


        public DateTime FechaPublicado { get; set; }

        public IList<ImagesProductoDTO> Imagenes { get; set; }


        public int CantidadDePuntos
        {
            get { return Puntos.Count; }
        }
        public int SumaDePuntos
        {
            get
            {
                int sumaDePuntos = 0;
                foreach (var punto in Puntos)
                {
                    sumaDePuntos += punto.Puntos;
                }
                return sumaDePuntos;
            }
        }




    }
}
