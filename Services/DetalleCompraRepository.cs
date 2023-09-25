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

        public void CreaDetalleCompra(int ordencompraId,int productoId, int cantidad)
        {
            var nuevaDetalleCompra = new EDetalleCompra
            {
                OrdenCompraId = ordencompraId,
                ProductoId = productoId,
                Cantidad = cantidad
            };

            _context.DetalleCompra.Add(nuevaDetalleCompra);
        }

        public IEnumerable<DetalleCompraDTO> GetDetalleCompra()
        {
            var detalleCompras = _context.DetalleCompra
              .OrderBy(x => x.Id)
              .ToList();

            return _mapper.Map<List<DetalleCompraDTO>>(detalleCompras);
        }

        public EDetalleCompra GetDetalleCompra(int id)
        {
            return _context.DetalleCompra
                .Where(c => c.Id == id)
                 .FirstOrDefault();
        }

    }
}
