using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs.OrdenCompra;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class OrdenCompraRepository : IOrdenCompraRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public OrdenCompraRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void CrearOrdenCompra(int usuarioId)
        {
            var nuevaOrdenCompra = new EOrdenCompra
            {
                UsuarioId = usuarioId,
                Estado = "pendiente"
            };

            _context.OrdenCompras.Add(nuevaOrdenCompra);
        }

        public void EliminarOrdenCompra(EOrdenCompra ordencompra)
        {
                _context.OrdenCompras.Remove(ordencompra);
            
        }

        public IEnumerable<OrdenCompraDTO> GetOrdenCompra()
        {
            var ordenCompras = _context.OrdenCompras
               .Include(c => c.DetalleCompra)
               .ThenInclude(dc => dc.Producto)

               .OrderBy(x => x.Id)
               .ToList();

            return _mapper.Map<List<OrdenCompraDTO>>(ordenCompras);
        }
        public EOrdenCompra GetOrdenCompra(int id)
        {
            return _context.OrdenCompras
               .Include(c => c.DetalleCompra)
               .ThenInclude(dc => dc.Producto)
               .Where(c => c.Id == id)
                .FirstOrDefault();
           
        }
        public IEnumerable<OrdenCompraDTO> GetOrdenCompraUser(int idUsuario)
        {
            var ordenCompras = _context.OrdenCompras
               .Include(c => c.DetalleCompra)
               .Where(c => c.UsuarioId == idUsuario)
                .ToList();
            return _mapper.Map<List<OrdenCompraDTO>>(ordenCompras);
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }


    }
}
