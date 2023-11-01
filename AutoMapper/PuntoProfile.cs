using AutoMapper;
using TpiBarberShop.DTOs.Punto;

namespace TpiBarberShop.AutoMapper
{
    public class PuntoProfile : Profile
    {
        public PuntoProfile()
        {
            CreateMap<Entities.EPuntos, PuntosDTO>();
            CreateMap<PuntosDTO, Entities.EPuntos>();


            CreateMap<Entities.EPuntos, PuntosFilterDTO>();
     
            CreateMap<PuntosCreacionDTO, Entities.EPuntos>();
            CreateMap<PuntosActualizarDTO, Entities.EPuntos>();


        }
    }
}
