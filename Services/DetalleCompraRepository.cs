using AutoMapper;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs;

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
        public IEnumerable<DetalleCompraDTO> GetDetalleCompra()
        {
            var detalleCompras = _context.DetalleCompra
              .OrderBy(x => x.Id)
              .ToList();

            return _mapper.Map<List<DetalleCompraDTO>>(detalleCompras);
        }
    }
}
