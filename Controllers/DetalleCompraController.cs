using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TpiBarberShop.DTOs.Detalle;
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
        public IActionResult GetDetalleCompraUser()
        {
            var detalleCompra = _DetalleCompraRepository.GetDetalleCompra();
            return Ok(detalleCompra);


        }

        [HttpGet("{id}")]

        public IActionResult GetDetalleCompraUser(int id)
        {
            var detalleCompra = _DetalleCompraRepository.GetDetalleCompra(id);

            return Ok(_mapper.Map<DetalleCompraDTO>(detalleCompra));

        }



        [HttpPost("{idOrdenCompra}/{idProducto}/{cantidad}")]

        public ActionResult CrearOrdenCompra(int idOrdenCompra,int idProducto, int cantidad)
        {

            _DetalleCompraRepository.CreaDetalleCompra(idOrdenCompra, idProducto, cantidad);
            _repository.GuardarCambios();

            return Ok("Producto añadido a la orden de compra Correctamente");


        }
    }
}
