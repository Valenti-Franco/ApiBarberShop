using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/DetaleCompra")]
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
    }
}
