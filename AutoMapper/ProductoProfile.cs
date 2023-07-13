using AutoMapper;

namespace TpiBarberShop.AutoMapper
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Entities.EProducto, DTOs.ProductoSinPuntoDTO>();
            CreateMap<Entities.EProducto, DTOs.ProductoDTO>();
            CreateMap<DTOs.ProductoCreacionDTO, Entities.EProducto>();
            CreateMap<DTOs.ProductoActualizarDTO, Entities.EProducto>();


        }
    }
}
