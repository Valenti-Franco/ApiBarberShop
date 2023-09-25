using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TpiBarberShop.DTOs.OrdenCompra;
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
        public IActionResult GetOrdenCompraUser()
        {
            var ordenCompra = _OrdenCompraRepository.GetOrdenCompra();
            return Ok(ordenCompra);


        }

        [HttpGet("{id}")]

        public IActionResult GetOrdenCompra(int id)
        {
            var ordenCompra = _OrdenCompraRepository.GetOrdenCompra(id);

            return Ok(_mapper.Map<OrdenCompraDTO>(ordenCompra));

        }

        [HttpGet("usuario/{idUsuario}")]
        public IActionResult GetOrdenCompraUser(int idUsuario)
        {
            var ordenCompra = _OrdenCompraRepository.GetOrdenCompraUser(idUsuario);
            return Ok(ordenCompra);


        }

        [HttpPut("{id}/ConfirmarOrdenCompra/Admin")]

        public ActionResult ConfirmarOrdenCompra(int id)
        {

            //var usuarioId = User.FindFirstValue("sub");
            //var usuarioActual = ObtenerUsuarioActual(usuarioId);
            //if (usuarioActual.Role != "Admin")
            //    return NotFound("No tenes los permisos actualizar Compra");

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

            //var usuarioId = User.FindFirstValue("sub");
            //var usuarioActual = ObtenerUsuarioActual(usuarioId);
            //if (usuarioActual.Role != "Admin")
            //{
            //    if (usuarioActual.Id != compraAEliminar.UsuarioId)
            //        return NotFound("No tenes los permisos para eliminar esta Compra");
            //}
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
      
        public ActionResult CrearOrdenCompra(int idUsuario)
        {

            _OrdenCompraRepository.CrearOrdenCompra(idUsuario);
            _repository.GuardarCambios();
             
            return Ok("Orden de Compra Creada Correctamente");

            
        }


    }
}
