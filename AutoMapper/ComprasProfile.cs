using AutoMapper;

namespace TpiBarberShop.AutoMapper
{
    public class ComprasProfile : Profile
    {
        public ComprasProfile()
        {
            CreateMap<Entities.ECompras, DTOs.CompraDTO>()
                //.ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.Producto, opt => opt.MapFrom(src => src.Producto));

            CreateMap<DTOs.CompraSinUserDTO, DTOs.CompraDTO>();
            CreateMap<DTOs.CompraDTO, DTOs.CompraSinUserDTO>();
            CreateMap<DTOs.CompraDTO, Entities.ECompras>();
        }
    }

    }
