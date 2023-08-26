namespace TpiBarberShop.DTOs
{
    public class PuntosFilterDTO
    {
        public int Id { get; set; }
        public int Puntos { get; set;}

        public string Nombre { get; set; } = string.Empty;

        public int UsuarioId { get; set; }
    }
}
    