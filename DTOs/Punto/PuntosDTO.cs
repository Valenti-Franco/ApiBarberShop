using TpiBarberShop.DTOs.Imagen;

namespace TpiBarberShop.DTOs.Punto
{
    public class PuntosDTO
    {
        public int Id { get; set; }
        public int Puntos { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public int ProductoId { get; set; }

        public int UsuarioId { get; set; }




    }
}
