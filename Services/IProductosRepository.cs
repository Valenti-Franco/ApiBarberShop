using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface IProductosRepository
    {
        
        public IEnumerable<EProducto> GetProductos();
        public IEnumerable<EProducto> GetProductosPuntos();
        public EProducto?  GetProducto(int ProductoId);
        public IEnumerable<EPuntos> GetPuntos(int ProductoId);
        public EPuntos? GetPuntosId( int PuntoId);
        bool ExisteProducto(int ProductoId);
        void AgregarPuntoAProducto(int ProductoId, EPuntos punto);
        bool GuardarCambios();
        void EliminarPunto(EPuntos punto);
        void AgregarProducto(EProducto prodcutoNuevo);
        void EliminarProducto(EProducto  producto);
        public EUsuarios? GetUsuarios(int idUsuario);
        EPuntos? ObtenerPuntoPorUsuarioId(int usuarioId, int id);
        void ActualizarPunto(EPuntos punto);
        void ReducirStock(EProducto producto);
        void AumentarStock(EProducto producto);
    }
}
