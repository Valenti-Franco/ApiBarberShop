using AutoMapper;
using TpiBarberShop.DTOs.Compra;

namespace TpiBarberShop.AutoMapper
{
    public class ComprasProfile : Profile
    {
        public ComprasProfile()
        {
            CreateMap<Entities.ECompras, CompraDTO>()
                //.ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.Producto, opt => opt.MapFrom(src => src.Producto));
            CreateMap<Entities.ECompras, CompraSinUserDTO>();

            CreateMap<CompraSinUserDTO, Entities.ECompras>();

            CreateMap<CompraSinUserDTO, CompraDTO>();
            CreateMap<CompraDTO, CompraSinUserDTO>();
            CreateMap<CompraDTO, Entities.ECompras>();


        }
    }

}
