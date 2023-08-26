using AutoMapper;

namespace TpiBarberShop.AutoMapper
{
    public class OrdenCompraProfile : Profile
    {
        public OrdenCompraProfile()
        {

            CreateMap<Entities.EOrdenCompra, DTOs.OrdenCompraDTO>();
            CreateMap<DTOs.OrdenCompraDTO, Entities.EOrdenCompra>();

            CreateMap<Entities.EDetalleCompra, DTOs.DetalleCompraDTO>();



        }
    }
}
