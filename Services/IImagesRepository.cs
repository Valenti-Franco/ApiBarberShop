using TpiBarberShop.DTOs.Imagen;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface IImagesRepository
    {
        public IEnumerable<ImagesUsuarioDTO> GetImageUsuario();

     

        public EImagenUsuario GetImageUsuario(int id);

        void EliminarImagesUsuario(EImagenUsuario imagen);

        void ActualizarImagenUsuario(EImagenUsuario imagen);

        public IEnumerable<ImagesProductoDTO> GetImagesProducto();
        public IEnumerable<ImagesProductoDTO> GetImagesProducto(int id);

        void AgregarImagenUsuario(EImagenUsuario ImagenNuevo);
        void AgregarImagenProducto(EImagenProducto ImagenNuevo);

        bool GuardarCambios();

    }
}
