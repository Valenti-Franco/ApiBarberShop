using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs.Imagen;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class ImagesRepository : IImagesRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public ImagesRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
      
        public EImagenProducto GetImagesProductoId(int id)
        {
            var imageProducto = _context.ImagenProductos
               .FirstOrDefault(x => x.Id == id);

            return imageProducto;
        }

        public IEnumerable<ImagesProductoDTO> GetImagesProducto(int id)
        {
            var imageProducto = _context.ImagenProductos

                .Where(x => x.ProductoId == id)
                .ToList();


            return _mapper.Map<List<ImagesProductoDTO>>(imageProducto);
        }
        public IEnumerable<ImagesProductoDTO> GetImagesProducto()
        {
            var imagesProducto = _context.ImagenProductos
           .OrderBy(x => x.Id)
           .ToList();

            return _mapper.Map<List<ImagesProductoDTO>>(imagesProducto);
        }

        public IEnumerable<ImagesUsuarioDTO> GetImageUsuario()
        {
            var imagesUsuarios = _context.ImagenUsuarios
            .OrderBy(x => x.Id)
            .ToList();

            return _mapper.Map<List<ImagesUsuarioDTO>>(imagesUsuarios);
        }

        public EImagenUsuario GetImageUsuario(int id)
        {
            var imageUsuario = _context.ImagenUsuarios
                .FirstOrDefault(x => x.UsuarioId == id);

            return imageUsuario;
        }


        public void AgregarImagenUsuario(EImagenUsuario ImagenNuevo)
        {

            _context.ImagenUsuarios.Add(ImagenNuevo);

        }

        public void AgregarImagenProducto(EImagenProducto ImagenNuevo)
        {

            _context.ImagenProductos.Add(ImagenNuevo);

        }
        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void EliminarImagesUsuario(EImagenUsuario imagen)
        {
            _context.ImagenUsuarios.Remove(imagen);
        }
        public void EliminarImagesProducto(EImagenProducto imagen)
        {
            _context.ImagenProductos.Remove(imagen);
        }


        public void ActualizarImagenUsuario(EImagenUsuario imagen)
        {
            _context.ImagenUsuarios.Update(imagen);
        }
    }
}
