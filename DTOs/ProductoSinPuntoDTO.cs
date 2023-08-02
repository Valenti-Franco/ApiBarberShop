using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.DTOs
{
    public class ProductoSinPuntoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

    }
}
