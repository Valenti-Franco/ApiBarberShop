using AutoMapper;

namespace TpiBarberShop.AutoMapper
{
    public class ImagesProfile : Profile
    {
        public ImagesProfile()
        {
            CreateMap<Entities.EImagenUsuario, DTOs.ImagesUsuarioDTO>();
            CreateMap<DTOs.ImageUsuarioCrearDTO, Entities.EImagenUsuario>();


        }

    }
}
