using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TpiBarberShop.DTOs.Detalle;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/DetalleCompra")]
    public class DetalleCompraController : Controller
    {

        private readonly IProductosRepository _repository;
        private readonly IDetalleCompraRepository _DetalleCompraRepository;


        private readonly IMapper _mapper;
        public DetalleCompraController(IProductosRepository repository, IDetalleCompraRepository DetalleCompraRepository, IMapper mapper)
        {
            _repository = repository;
            _DetalleCompraRepository = DetalleCompraRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetDetalleCompraUser()
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);


            if (usuarioActual.Role != "Admin" )
            {
                return NotFound("No tenes los permisos para ver este usuario");
            }
            var detalleCompra = _DetalleCompraRepository.GetDetalleCompra();
            return Ok(detalleCompra);


        }

        [HttpGet("{id}")]
        [Authorize]

        public IActionResult GetDetalleCompraUser(int id)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);


            if (usuarioActual.Role != "Admin")
            {
                return NotFound("No tenes los permisos para ver este usuario");
            }
            var detalleCompra = _DetalleCompraRepository.GetDetalleCompra(id);

            return Ok(_mapper.Map<DetalleCompraDTO>(detalleCompra));

        }



        [HttpPost("{idOrdenCompra}/{idProducto}/{cantidad}")]
        [Authorize]

        public ActionResult CrearOrdenCompra(int idOrdenCompra, int idProducto, int cantidad)
        {
            var producto = _repository.GetProducto(idProducto);
            if (producto != null)
            {
                try
                {
                    _repository.ReducirStock(producto, cantidad);
                    _DetalleCompraRepository.CreaDetalleCompra(idOrdenCompra, idProducto, cantidad);

                    _repository.GuardarCambios();

                    return Ok("Producto añadido a la orden de compra Correctamente");

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message); // Return an appropriate error message when stock is 0
                }
            }


            string mensajeError = "El Producto actual no se pudo encontrar.";
            return BadRequest(mensajeError);
        }

        private EUsuarios ObtenerUsuarioActual(string usuarioId)
        {
            var usuario = _repository.GetUsuarios(int.Parse(usuarioId));

            return usuario;
        }
    }
}
