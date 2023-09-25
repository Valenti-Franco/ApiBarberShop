using System.ComponentModel.DataAnnotations;
using TpiBarberShop.DTOs.Imagen;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs.Producto
{
    public class ProductoSinPuntoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }


        public int SubcategoryId { get; set; }

        public IList<ImagesProductoDTO> Imagenes { get; set; }




    }
}
