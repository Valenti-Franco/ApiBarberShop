using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class ComprasRepository : IComprasRepository
    {

        private readonly Context _context;
        private readonly IMapper _mapper;
        public ComprasRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


    public IEnumerable<CompraDTO> GetCompras()
{
    var compras = _context.Compras
        //.Include(c => c.Usuario)
        .Include(c => c.Producto)
        .OrderBy(x => x.Id)
        .ToList();

    var comprasDto = _mapper.Map<List<CompraDTO>>(compras);

    return comprasDto;
}

        public ECompras GetCompras(int comprasId)
        {
            return _context.Compras
                .Include(c => c.Producto)
                .FirstOrDefault(c => c.Id == comprasId);
        }

        public IEnumerable<ECompras> GetComprasConfirmadas()
        {
            return _context.Compras
                //.Include(c => c.Usuario)
                .Include(c => c.Producto)
                .Where(c => c.Estado == "confirmada")
                .OrderBy(x => x.Id)
                .ToList();
        }

        public IEnumerable<ECompras> GetComprasPendientes()
        {
            return _context.Compras
                //.Include(c => c.Usuario)
                .Include(c => c.Producto)
                .Where(c => c.Estado == "pendiente")
                .OrderBy(x => x.Id)
                .ToList();
        }

        public void CrearNuevaCompra(int usuarioId, int productoId, int Cantidad)
        {
            var nuevaCompra = new ECompras
            {
                UsuarioId = usuarioId,
                ProductoId = productoId,
                Cantidad = Cantidad,
                Estado = "pendiente"
            };

            _context.Compras.Add(nuevaCompra);
        }
        public void EliminarCompra(ECompras compra)
        {
            _context.Compras.Remove(compra);
        }
        public void EliminarCompraUser(int usuarioid)
        {
            var comprasAEliminar = _context.Compras.Where(c => c.UsuarioId == usuarioid).ToList();
            _context.Compras.RemoveRange(comprasAEliminar);

        }
        public List<CompraDTO> GetComprasByUsuarioId(int usuarioId)
        {
            var compras = _context.Compras
                .Where(c => c.UsuarioId == usuarioId)
                .ToList();

            var comprasDTO = compras.Select(c => new CompraDTO
            {
                Id = c.Id,
                UsuarioId = c.UsuarioId,
                ProductoId = c.ProductoId,
                Estado = c.Estado
            }).ToList();

            return comprasDTO;
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }

    
    }
}
