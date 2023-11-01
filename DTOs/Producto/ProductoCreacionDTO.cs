using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.DTOs.Producto
{
    public class ProductoCreacionDTO
    {
        [Required(ErrorMessage = "Agrega un Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Agrega una Cantidad de Stock")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Agrega un Precio")]

        public int Precio { get; set; }
        public int CategoryId { get; set; }


        public int SubcategoryId { get; set; }


        public string? Descripcion { get; set; }
    }
}
