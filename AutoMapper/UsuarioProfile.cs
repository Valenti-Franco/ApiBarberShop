using AutoMapper;
using TpiBarberShop.DTOs;

namespace TpiBarberShop.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Entities.EUsuarios, UsuariosLoginDTO>();
            CreateMap<DTOs.UsuarioCreacionDTO, Entities.EUsuarios>();

            CreateMap<Entities.EUsuarios, DTOs.UsuariosDTO>();
            CreateMap<DTOs.UsuariosDTO, Entities.EUsuarios>();



        }
    }
    
}
