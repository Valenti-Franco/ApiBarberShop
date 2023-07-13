using AutoMapper;
using TpiBarberShop.DTOs;

namespace TpiBarberShop.AutoMapper
{
    public class PuntoProfile : Profile
    {
        public PuntoProfile()
        {
            CreateMap<Entities.EPuntos, DTOs.PuntosDTO>();
            CreateMap<DTOs.PuntosDTO, Entities.EPuntos>(); 
            CreateMap<DTOs.PuntosCreacionDTO, Entities.EPuntos>();
            CreateMap<DTOs.PuntosActualizarDTO, Entities.EPuntos>();


        }
    }
}
