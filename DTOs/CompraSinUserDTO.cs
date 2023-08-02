namespace TpiBarberShop.DTOs
{
    public class CompraSinUserDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ProductoId { get; set; }
        public string? Estado { get; set; } = "Pendiente";
    }
}
