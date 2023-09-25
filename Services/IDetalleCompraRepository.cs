using TpiBarberShop.DTOs.Detalle;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface IDetalleCompraRepository
    {
        public IEnumerable<DetalleCompraDTO> GetDetalleCompra();

        public EDetalleCompra GetDetalleCompra(int id);

        void CreaDetalleCompra(int ordencompraId, int productoId, int cantidad);


    }
}
