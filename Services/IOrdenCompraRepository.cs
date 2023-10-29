using TpiBarberShop.DTOs.OrdenCompra;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface IOrdenCompraRepository
    {
        public IEnumerable<OrdenCompraDTO> GetOrdenCompra();
        public EOrdenCompra GetOrdenCompra(int id);
        bool GuardarCambios();

        public IEnumerable<OrdenCompraDTO> GetOrdenCompraUser(int idUsuario);
        void EliminarOrdenCompra(EOrdenCompra ordencompra);

        EOrdenCompra CrearOrdenCompra(int usuarioId);

    }
}
