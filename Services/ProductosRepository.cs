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

        public IEnumerable<EProducto> GetProductos()
        {
           return  _context.Productos.OrderBy(x => x.Nombre).ToList();
        }

        public IEnumerable<EPuntos> GetPuntos(int ProductoId)
        {
            return _context.Puntos.Where(p => p.ProductoId == ProductoId).ToList();
        }

        public EPuntos? GetPuntos(int ProductoId, int PuntoId)
        {
            return _context.Puntos.Where(c => c.Id == PuntoId && c.ProductoId == ProductoId).FirstOrDefault();
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
    }
}
