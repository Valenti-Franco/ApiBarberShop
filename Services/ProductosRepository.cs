using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class ProductosRepository : IProductosRepository
    {
        private readonly Context _context;

        public ProductosRepository(Context context)
        {
            _context = context;
        }
        public EProducto? GetProducto(int ProductoId)
        {
           return _context.Productos.Include(c => c.Puntos).Where(c => c.Id == ProductoId).FirstOrDefault();
        }
        public IEnumerable<EProducto> GetProductosPuntos()
        {
            return _context.Productos.Include(c => c.Puntos).OrderBy(x => x.Nombre).ToList();
        }
        public IEnumerable<EProducto> GetProductos()
        {
           return  _context.Productos.OrderBy(x => x.Nombre).ToList();
        }

        public IEnumerable<EPuntos> GetPuntos(int ProductoId)
        {
            return _context.Puntos.Where(p => p.ProductoId == ProductoId).ToList();
        }

        public EPuntos? GetPuntosId( int PuntoId)
        {
            return _context.Puntos.Where(c => c.Id == PuntoId).FirstOrDefault();
        }

        public bool ExisteProducto(int ProductoId)
        {
            return _context.Productos.Where(c=> c.Id == ProductoId).Any();
        }
        public void AgregarProducto( EProducto productoNuevo)
        {

            _context.Productos.Add(productoNuevo);
            
        }
        public void AgregarPuntoAProducto(int ProductoId, EPuntos punto)
        {
            var producto = GetProducto(ProductoId);
            if (producto != null)
            {
                producto.Puntos.Add(punto);
            }
        }
        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void EliminarPunto(EPuntos punto)
        {
            _context.Puntos.Remove(punto);
        }
        public void EliminarPuntoUser( int usuarioId)
        {
            var puntosAEliminar = _context.Puntos.Where(p => p.UsuarioId == usuarioId).ToList();
            _context.Puntos.RemoveRange(puntosAEliminar);
        }
        public void EliminarProducto(EProducto producto)
        {
            _context.Productos.Remove(producto);
        }

        public EUsuarios? GetUsuarios(int idUsuario)
        {
            return _context.Usuarios.Find(idUsuario);
        }

        public EPuntos? ObtenerPuntoPorUsuarioId(int usuarioId, int id)
        {
            return _context.Puntos.FirstOrDefault(p => p.UsuarioId == usuarioId && p.ProductoId == id);
        }

        public void ActualizarPunto(EPuntos punto)
        {
            _context.Puntos.Update(punto);
        }
        public void ReducirStock(EProducto producto)
        {
            if (producto != null && producto.Stock > 0)
            {
                producto.Stock -= 1;
                _context.Productos.Update(producto);

            }
            else
            {
                throw new Exception("No hay más stock disponible para este producto");
            }
        }
        public void AumentarStock(EProducto producto)
        {
           
        producto.Stock += 1;
        _context.Productos.Update(producto);

            
           
        }
    }
}
