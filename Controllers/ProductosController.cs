using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [ApiController]


    [Route("api/Productos")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductosRepository _repository;
        private readonly IMapper _mapper;
        public ProductosController(IProductosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetProductos()
        {
            var productos = _repository.GetProductos();
            return Ok(_mapper.Map<IEnumerable<ProductoSinPuntoDTO>>(productos));


        }
        [HttpGet("Puntos")]
        public IActionResult GetProductosPuntos()
        {
            var productos = _repository.GetProductosPuntos();
            return Ok(_mapper.Map<IEnumerable<ProductoDTO>>(productos));



        }
        [HttpGet("{id}")]
        public IActionResult GetProductos(int id)
        {
            var producto = _repository.GetProducto(id);
            if (producto is null)
            {
                return NotFound("No se encontro el Producto");
            }

            return Ok(producto);


        }

        [HttpPost]
        [Authorize]
        public ActionResult<ProductoDTO> CreacionPunto(ProductoCreacionDTO productoACrear)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound("No tenes los permisos para Agregar Productos");
            }

            EProducto ProdcutoNuevo = _mapper.Map<EProducto>(productoACrear);

            _repository.AgregarProducto(ProdcutoNuevo);
            _repository.GuardarCambios();

            return Ok(_mapper.Map<ProductoDTO>(ProdcutoNuevo));
        }

        [HttpPut("{idProducto}/Admin")]
        [Authorize]
        public ActionResult ActualizarPunto(int idProducto, ProductoActualizarDTO productoActualizado)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound("No tenes los permisos para actualizar el Producto");
            }
            if (!_repository.ExisteProducto(idProducto))
                return NotFound("No se encontro el Producto");

            var productoAAactulizar = _repository.GetProducto(idProducto);

            _mapper.Map(productoActualizado, productoAAactulizar);
            _repository.GuardarCambios();

            return NoContent();

        }

        


        [HttpDelete("{idProducto}/Admin")]
        [Authorize]
        public ActionResult EliminarProductoAdmin(int idProducto)
        {

            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound("No se tenes los permisos para eliminar el Producto");
            }
            var productoAEliminar = _repository.GetProducto(idProducto);
            if (productoAEliminar is null)
                return NotFound("No se encontro el Producto");

            _repository.EliminarProducto(productoAEliminar);
            _repository.GuardarCambios();

            return NoContent();

        }
       
        private EUsuarios ObtenerUsuarioActual(string usuarioId)
        {
            var usuario = _repository.GetUsuarios(int.Parse(usuarioId));

            return usuario;
        }
    }
}
