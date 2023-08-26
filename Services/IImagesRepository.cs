using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface IImagesRepository
    {
        public IEnumerable<ImagesUsuarioDTO> GetImageUsuario();
        public IEnumerable<ImagesProductoDTO> GetImagesProducto();
        void AgregarImagenUsuario(EImagenUsuario ImagenNuevo);
        bool GuardarCambios();

    }
}
