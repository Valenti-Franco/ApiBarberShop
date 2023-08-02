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
    [Route("api/puntos")]
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
        [HttpGet("Producto/{idProducto}")]
        public ActionResult<List<PuntosDTO>> GetPuntos(int idProducto)
        {
            
            if(!_repository.ExisteProducto(idProducto))
                return NotFound("El producto no existe");

            List<Entities.EPuntos>? puntos = _repository.GetPuntos(idProducto).ToList();
            return Ok(_mapper.Map<List<PuntosDTO>>(puntos));
        }

        [HttpGet("{idPunto}")]

        public ActionResult<PuntosDTO> GetPuntosId( int idPunto)
        {

            Entities.EPuntos? punto = _repository.GetPuntosId(idPunto);

            if (punto is null)
            {
                return NotFound("El punto no existe");

            }
            return Ok(_mapper.Map<PuntosDTO>(punto));



        }

        [HttpPost("{idProducto}")]
        [Authorize]
        public ActionResult<PuntosDTO> CreacionPunto(int idProducto, PuntosCreacionDTO puntoACrear)
        {
            if (!_repository.ExisteProducto(idProducto))
                return NotFound("El producto no existe");


            var usuarioId = User.FindFirstValue("sub");   

            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            var puntoExistente = _repository.ObtenerPuntoPorUsuarioId(usuarioActual.Id, idProducto);
            if (puntoExistente?.ProductoId == idProducto)
                return NotFound("El punto ya fue creado");


            var puntoNuevo = _mapper.Map<Entities.EPuntos>(puntoACrear);
            puntoNuevo.Nombre = usuarioActual.Nombre;
            puntoNuevo.UsuarioId = usuarioActual.Id;
            _repository.AgregarPuntoAProducto(idProducto, puntoNuevo);


            _repository.GuardarCambios();

            return Ok("Punto Creado"); // Devuelve el punto creado
        }

        [HttpPut("{idPunto}")]
        [Authorize]
        public ActionResult ActualizarPunto( int idPunto, PuntosActualizarDTO puntoActualizado)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            


            var puntoAAactulizar = _repository.GetPuntosId( idPunto);
            if (puntoAAactulizar is null)
                return NotFound("El Punto no existe");
            if (usuarioActual.Role != "Admin")
            {
                if (usuarioActual.Id != puntoAAactulizar?.UsuarioId)
                {
                    return Forbid("No tenes los permisos para editar este Punto");
                }
            }       

            _mapper.Map(puntoActualizado, puntoAAactulizar);
            _repository.GuardarCambios();

            return Ok("Punto Editado correctamente");
        }

      

        [HttpDelete("{idPunto}")]
        [Authorize]

        public ActionResult EliminarPunto( int idPunto)
        {
           
            var puntoAEliminar = _repository.GetPuntosId(idPunto);
            if (puntoAEliminar is null)
                return NotFound("El punto no existe");

            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            if (usuarioActual.Role != "Admin")
            {
                if (usuarioActual.Id != puntoAEliminar.UsuarioId)
                {
                    return Forbid("No tenes los permisos para eliminar este Punto");
                }
            }
            

            _repository.EliminarPunto(puntoAEliminar);
            _repository.GuardarCambios();

            return Ok("Punto Eliminado correctamente");


        }

        private EUsuarios ObtenerUsuarioActual(string usuarioId)
        {
            var usuario = _repository.GetUsuarios(int.Parse(usuarioId));

            return usuario;
        }
    }

}
