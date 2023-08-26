using TpiBarberShop.DTOs;

namespace TpiBarberShop.Services
{
    public interface IDetalleCompraRepository
    {
        public IEnumerable<DetalleCompraDTO> GetDetalleCompra();
    }
}
