using AutoMapper;
using TpiBarberShop.DTOs.Imagen;

namespace TpiBarberShop.AutoMapper
{
    public class ImagesProfile : Profile
    {
        public ImagesProfile()
        {
            CreateMap<Entities.EImagenUsuario, ImagesUsuarioDTO>();
            CreateMap<Entities.EImagenProducto, ImagesProductoDTO>();

            CreateMap<ImageUsuarioCrearDTO, Entities.EImagenUsuario>();
            CreateMap<ImageProductoCrearDTO, Entities.EImagenProducto>();


            CreateMap<ImagesUsuarioDTO, Entities.EImagenUsuario>();
            CreateMap<ImagesProductoDTO, Entities.EImagenProducto>();





        }

    }
}
