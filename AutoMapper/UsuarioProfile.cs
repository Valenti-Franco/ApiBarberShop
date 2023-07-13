using AutoMapper;
using TpiBarberShop.DTOs;

namespace TpiBarberShop.AutoMapper
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Entities.EUsuarios, UsuariosLoginDTO>();
            CreateMap<DTOs.UsuarioCreacionDTO, Entities.EUsuarios>();


        }
    }
    
}
