using AutoMapper;
using TpiBarberShop.DTOs.Detalle;
using TpiBarberShop.DTOs.OrdenCompra;

namespace TpiBarberShop.AutoMapper
{
    public class OrdenCompraProfile : Profile
    {
        public OrdenCompraProfile()
        {

            CreateMap<Entities.EOrdenCompra, OrdenCompraDTO>();
            CreateMap<OrdenCompraDTO, Entities.EOrdenCompra>();

            CreateMap<Entities.EDetalleCompra, DetalleCompraDTO>();



        }
    }
}
