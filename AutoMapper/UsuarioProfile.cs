using AutoMapper;
using TpiBarberShop.DTOs.Usuario;

namespace TpiBarberShop.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Entities.EUsuarios, UsuariosLoginDTO>();
            CreateMap<UsuarioCreacionDTO, Entities.EUsuarios>();

            CreateMap<Entities.EUsuarios, UsuariosDTO>();
            CreateMap<UsuariosDTO, Entities.EUsuarios>();



        }
    }
    
}
