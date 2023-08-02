using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.DTOs
{
    public class ProductoActualizarDTO
    {
        [Required(ErrorMessage = "Agrega un Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Agrega un Precio")]

        public int Precio { get; set; }


        [Required(ErrorMessage = "Agrega una Cantidad de Stock")]
        public int Stock { get; set; }
        public string? Descripcion { get; set; }

    }
}
