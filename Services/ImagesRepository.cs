using AutoMapper;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs;
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
        public IEnumerable<ImagesProductoDTO> GetImagesProducto()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ImagesUsuarioDTO> GetImageUsuario()
        {
            var imagesUsuarios = _context.ImagenUsuarios
            .OrderBy(x => x.Id)
            .ToList();

            return _mapper.Map<List<ImagesUsuarioDTO>>(imagesUsuarios);
        }

        public void AgregarImagenUsuario(EImagenUsuario ImagenNuevo)
        {

            _context.ImagenUsuarios.Add(ImagenNuevo);

        }
        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
