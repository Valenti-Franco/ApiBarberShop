using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosController : ControllerBase

    {

        private readonly IUsuariosRepository _repository;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuariosRepository repository, IMapper mapper, IConfiguration config)
        {
            _repository = repository;
            _config = config;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(_repository.GetUsuarios());


        }
        [HttpGet("{id}")]
        public IActionResult GetUsuarios(int id)
        {
            var usuario = _repository.GetUsuarios(id);
            if (usuario is null)
            {
                return NotFound();
            }
            return Ok(usuario);


        }
        [HttpPost("authenticate")] //Vamos a usar un POST ya que debemos enviar los datos para hacer el login
        public ActionResult<string> Autenticar(UsuariosLoginDTO usuario) //Enviamos como parámetro la clase que creamos arriba
        {
            ////Paso 1: Validamos las credenciales
            var user = ValidateCredentials(usuario); //Lo primero que hacemos es llamar a una función que valide los parámetros que enviamos.

            if (user is null) //Si el la función de arriba no devuelve nada es porque los datos son incorrectos, por lo que devolvemos un Unauthorized (un status code 401).
                return Unauthorized();

            var securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"])); //Traemos la SecretKey del Json. agregar antes: using Microsoft.IdentityModel.Tokens;

            var credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

            //Los claims son datos en clave->valor que nos permite guardar data del usuario.
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.Id.ToString())); //"sub" es una key estándar que significa unique user identifier, es decir, si mandamos el id del usuario por convención lo hacemos con la key "sub".
            claimsForToken.Add(new Claim("given_name", user.Nombre)); //Lo mismo para given_name y family_name, son las convenciones para nombre y apellido. Ustedes pueden usar lo que quieran, pero si alguien que no conoce la app
            claimsForToken.Add(new Claim("Email", user.Email)); //quiere usar la API por lo general lo que espera es que se estén usando estas keys.
            claimsForToken.Add(new Claim("role", user.Role ?? "Admin")); //Debería venir del usuario

            var jwtSecurityToken = new JwtSecurityToken( //agregar using System.IdentityModel.Tokens.Jwt; Acá es donde se crea el token con toda la data que le pasamos antes.
              _config["Authentication:Issuer"],
              _config["Authentication:Audience"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddHours(1),
              credentials);

            var tokenToReturn = new JwtSecurityTokenHandler() //Pasamos el token a string
                .WriteToken(jwtSecurityToken);

            return Ok(tokenToReturn);
        }
        private EUsuarios? ValidateCredentials(UsuariosLoginDTO authParams)
        {
            return _repository.ValidateUser(authParams);
        }
        [HttpPost("Admin")]
        [Authorize]
        public ActionResult<UsuariosDTO> CreacionUsuario(UsuarioCreacionDTO usuarioACrear)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound();
            }

            EUsuarios UsuarioNuevo = _mapper.Map<EUsuarios>(usuarioACrear);

            _repository.AgregarUsuario(UsuarioNuevo);
            _repository.GuardarCambios();

            return Ok();
        }

        [HttpPut("{id}")]
        
        public IActionResult EditarNombreUsuario(int id, [FromBody] EditarNombreUsuarioDTO nombreUsuarioDto)
        {
            var usuario = _repository.GetUsuarios(id);
            if (usuario is null)
            {
                return NotFound();
            }
            var usuarioId = User.FindFirstValue("sub");

            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Id != id)
            {
                return Forbid();
            }

            usuario.Nombre = nombreUsuarioDto.Nombre;
            _repository.GuardarCambios();

            return Ok(usuario);
        }

        [HttpPut("{id}/Admin")]
        [Authorize]
        public IActionResult EditarNombreUsuarioAdmin(int id, [FromBody] EditarNombreUsuarioDTO nombreUsuarioDto)
        {
            var usuario = _repository.GetUsuarios(id);
            if (usuario is null)
            {
                return NotFound();
            }
            var usuarioId = User.FindFirstValue("sub");
            if (usuarioId == null)
            {
                return NotFound();
            }
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound();
            }

            usuario.Nombre = nombreUsuarioDto.Nombre;
            _repository.GuardarCambios();

            return Ok(usuario);
        }

        private EUsuarios ObtenerUsuarioActual(string usuarioId)
        {
            var usuario = _repository.GetUsuarios(int.Parse(usuarioId));

            return usuario;
        }
       

        [HttpDelete("{idUsuario}/Admin")]
        public ActionResult EliminarProducto(int idUsuario)
        {


            var usuarioAEliminar = _repository.GetUsuarios(idUsuario);
            if (usuarioAEliminar is null)
                return NotFound();

            var usuarioId = User.FindFirstValue("sub");
            if (usuarioId == null )
            {
                return NotFound();
            }
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound();
            }

            _repository.EliminarUsuario(usuarioAEliminar);
            _repository.GuardarCambios();

            return NoContent();

        }




    }
}

