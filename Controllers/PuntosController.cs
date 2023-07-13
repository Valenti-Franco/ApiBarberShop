using System.Data;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [Route("api/productos/{id}/puntos")]
    [ApiController]
    public class PuntosController : ControllerBase
    {
        private readonly IProductosRepository _repository;
        private readonly IMapper _mapper;

        public PuntosController(IProductosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<PuntosDTO>> GetPuntos(int id)
        {
            
            if(!_repository.ExisteProducto(id))
                return NotFound();

            List<Entities.EPuntos>? puntos = _repository.GetPuntos(id).ToList();
            return Ok(_mapper.Map<List<PuntosDTO>>(puntos));
        }

        [HttpGet("{idPunto}")]

        public ActionResult<PuntosDTO> GetPuntos(int id, int idPunto)
        {
            if (!_repository.ExisteProducto(id))
                return NotFound();
            Entities.EPuntos? punto = _repository.GetPuntos(id, idPunto);

            if (punto is null)
            {
                return NotFound();  
            }
            return Ok(_mapper.Map<PuntosDTO>(punto));



        }

        [HttpPost]
        public ActionResult<PuntosDTO> CreacionPunto(int id, PuntosCreacionDTO puntoACrear)
        {
            if (!_repository.ExisteProducto(id))
                return NotFound();

            var usuarioId = User.FindFirstValue("sub");
            if (usuarioId == null)
                return NotFound();
            

            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            var puntoExistente = _repository.ObtenerPuntoPorUsuarioId(usuarioActual.Id, id);
            if (puntoExistente?.ProductoId == id )
                return NotFound();


            var puntoNuevo = _mapper.Map<Entities.EPuntos>(puntoACrear);
            puntoNuevo.Nombre = usuarioActual.Nombre;
            puntoNuevo.UsuarioId = usuarioActual.Id;
            _repository.AgregarPuntoAProducto(id, puntoNuevo);


            _repository.GuardarCambios();

            return Ok("Punto Enviado"); // Devuelve el punto creado
        }

        [HttpPut("{idPunto}")]
        [Authorize]
        public ActionResult ActualizarPunto(int id, int idPunto, PuntosActualizarDTO puntoActualizado)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            

            if (!_repository.ExisteProducto(id))
                return NotFound();

            var puntoAAactulizar = _repository.GetPuntos(id, idPunto);

            if (usuarioActual.Id != puntoAAactulizar?.UsuarioId)
            {
                return Forbid();
            }

            if (puntoAAactulizar is null)
                return NotFound();

            _mapper.Map(puntoActualizado, puntoAAactulizar);
            _repository.GuardarCambios();

            return NoContent();
        }

        [HttpPut("{idPunto}/Admin")]
        [Authorize]
        public ActionResult ActualizarPuntoAdmin(int id, int idPunto, PuntosActualizarDTO puntoActualizado)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound();
            }
            if (!_repository.ExisteProducto(id))
                return NotFound();

            var puntoAAactulizar = _repository.GetPuntos(id, idPunto);
            
            if (puntoAAactulizar is null)
                return NotFound();

            _mapper.Map(puntoActualizado, puntoAAactulizar);
            _repository.GuardarCambios();

            return NoContent();
        }

        [HttpDelete("{idPunto}/Admin")]
        
        public ActionResult EliminarPuntoAdmin(int id, int idPunto)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound();
            }
            if (!_repository.ExisteProducto(id))
                return NotFound();

            var puntoAEliminar = _repository.GetPuntos(id, idPunto);
            if (puntoAEliminar is null)
                return NotFound();

            _repository.EliminarPunto(puntoAEliminar);
            _repository.GuardarCambios();

            return NoContent();

        }

        [HttpDelete("{idPunto}")]
        public ActionResult EliminarPunto(int id, int idPunto)
        {
            var puntoAEliminar = _repository.GetPuntos(id, idPunto);
            if (puntoAEliminar is null)
                return NotFound();

            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Id != puntoAEliminar.UsuarioId)
            {
                return Forbid();
            }
            

            _repository.EliminarPunto(puntoAEliminar);
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
