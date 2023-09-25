using AutoMapper;
using TpiBarberShop.DTOs.Producto;

namespace TpiBarberShop.AutoMapper
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Entities.EProducto, ProductoSinPuntoDTO>();
            CreateMap<Entities.EProducto, ProductoDTO>();
           

            CreateMap<ProductoCreacionDTO, Entities.EProducto>();
            CreateMap<ProductoActualizarDTO, Entities.EProducto>();


        }
    }
}
