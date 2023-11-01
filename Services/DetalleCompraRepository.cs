using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs.Detalle;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class DetalleCompraRepository : IDetalleCompraRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public DetalleCompraRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void CreaDetalleCompra(int ordencompraId, int productoId, int cantidad)
        {
            var nuevaDetalleCompra = new EDetalleCompra
            {
                OrdenCompraId = ordencompraId,
                ProductoId = productoId,
                Cantidad = cantidad
            };

            // Obtener la orden de compra correspondiente y agregar el nuevo detalle
            var ordenCompra = _context.OrdenCompras.Include(o => o.DetalleCompra).FirstOrDefault(o => o.Id == ordencompraId);
            if (ordenCompra != null)
            {
                ordenCompra.DetalleCompra.Add(nuevaDetalleCompra);
                _context.SaveChanges(); // Entity Framework actualizará el valor total automáticamente
            }
        }

        public IEnumerable<DetalleCompraDTO> GetDetalleCompra()
        {
            var detalleCompras = _context.DetalleCompra
              .OrderBy(x => x.Id)
              .Include(x => x.Producto)
              .ToList();

            return _mapper.Map<List<DetalleCompraDTO>>(detalleCompras);
        }

        public DetalleCompraDTO GetDetalleCompra(int id)
        {
            var detalleCompra = _context.DetalleCompra
                .Where(c => c.Id == id).Include(x => x.Producto)
                 .FirstOrDefault();

            return _mapper.Map<DetalleCompraDTO>(detalleCompra);
        }

    }
}
