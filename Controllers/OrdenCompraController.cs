using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TpiBarberShop.DTOs.OrdenCompra;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/OrdenCompra")]

    public class OrdenCompraController : Controller
    {
        private readonly IProductosRepository _repository;
        private readonly IOrdenCompraRepository _OrdenCompraRepository;


        private readonly IMapper _mapper;
        public OrdenCompraController(IProductosRepository repository, IOrdenCompraRepository OdenCompraRepository, IMapper mapper)
        {
            _repository = repository;
            _OrdenCompraRepository = OdenCompraRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]

        public IActionResult GetOrdenCompraUser()
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            if (usuarioActual.Role != "Admin")
            {
               return NotFound("No tenes los permisos para ver este usuario");
            }
            var ordenCompra = _OrdenCompraRepository.GetOrdenCompra();
            return Ok(ordenCompra);


        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetOrdenCompra(int id)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            
            var ordenCompra = _OrdenCompraRepository.GetOrdenCompra(id);

            if (usuarioActual.Role != "Admin")
            {
                if (usuarioActual.Id != ordenCompra.UsuarioId)
                    return NotFound("No tenes los permisos para ver este usuario");
            }

            return Ok(_mapper.Map<OrdenCompraDTO>(ordenCompra));

        }

        [HttpGet("usuario/{idUsuario}")]
        [Authorize]

        public IActionResult GetOrdenCompraUser(int idUsuario)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin" )
            {
                if (usuarioActual.Id != idUsuario)
                    return NotFound("No tenes los permisos para ver este usuario");
            }

            var ordenCompra = _OrdenCompraRepository.GetOrdenCompraUser(idUsuario);
            return Ok(ordenCompra);


        }

        [HttpPut("{id}/ConfirmarOrdenCompra/Admin")]
        [Authorize]

        public ActionResult ConfirmarOrdenCompra(int id)
        {

            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            if (usuarioActual.Role != "Admin")
                return NotFound("No tenes los permisos actualizar Compra");

            var ordencompra = _OrdenCompraRepository.GetOrdenCompra(id);

            if (ordencompra == null)
            {
                return NotFound("No existe esa Orden de Compra");
            }

            if (ordencompra.Estado == "confirmada")
            {
                return BadRequest("La Orden de compra ya está confirmada");
            }

            ordencompra.Estado = "confirmada";
            _repository.GuardarCambios();

            return NoContent();
        }

        [HttpDelete("{idOrdenCompra}")]
        [Authorize]
        public ActionResult EliminarOrdenCompraPendiente(int idOrdenCompra)
        {

            var compraAEliminar = _OrdenCompraRepository.GetOrdenCompra(idOrdenCompra);


            if (compraAEliminar is null)
                return NotFound(compraAEliminar);


            if (compraAEliminar.Estado != "pendiente")
                return NotFound(compraAEliminar);

            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                if (usuarioActual.Id != compraAEliminar.UsuarioId)
                    return NotFound("No tenes los permisos para eliminar esta Compra");
            }
            var detalleCompra = compraAEliminar.DetalleCompra;

            foreach (var detalle in detalleCompra)
            {
                var productoId = detalle.ProductoId;
                var cantidad = detalle.Cantidad;

                // Obtener el producto desde el repositorio usando su ID.
                var producto = _repository.GetProducto(productoId);

                if (producto != null)
                {
                    // Aumentar el stock del producto en la cantidad especificada.
                    _repository.AumentarStock(producto, cantidad);
                }
                else
                {
                    // Manejar el caso en el que no se encuentra el producto en el repositorio.
                    // Puede lanzar una excepción o realizar alguna acción adecuada.
                }
            }

            // Finalmente, eliminar la compra después de ajustar el stock de los productos.
            _OrdenCompraRepository.EliminarOrdenCompra(compraAEliminar);
            _repository.GuardarCambios();

            return NoContent();

        }

        [HttpPost("{idUsuario}")]
        [Authorize]
        public ActionResult CrearOrdenCompra(int idUsuario)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin" && usuarioActual.Role != "Editor")
            {
                if (usuarioActual.Id != idUsuario)
                    return NotFound("No tenes los permisos para ver este usuario");
            }
            var ordenCompra = _OrdenCompraRepository.CrearOrdenCompra(usuarioActual.Id);
            _repository.GuardarCambios();
             
            return Ok(_mapper.Map<OrdenCompraDTO>(ordenCompra));

            
        }

        private EUsuarios ObtenerUsuarioActual(string usuarioId)
        {
            var usuario = _repository.GetUsuarios(int.Parse(usuarioId));

            return usuario;
        }
    }
}
