using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs
{
    public class UsuariosDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;


        public IList<CompraSinUserDTO> Compras { get; set; }

        public IList<ImagesUsuarioDTO> Imagenes { get; set; }



    }
}
