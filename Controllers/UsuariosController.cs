using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using TpiBarberShop.DTOs.Usuario;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosController : ControllerBase

    {

        private readonly IUsuariosRepository _repository;
        private readonly IComprasRepository _ComprasRepository;
        private readonly IProductosRepository _ProductoRepository;

        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuariosRepository repository, IComprasRepository ComprasRepository, IProductosRepository ProductoRepository, IMapper mapper, IConfiguration config)
        {
            _repository = repository;
            _config = config;
            _mapper = mapper;
            _ComprasRepository = ComprasRepository;
            _ProductoRepository = ProductoRepository;
        }

        [HttpGet("Admin")]
        //[Authorize]
        public IActionResult GetUsuarios()
        {

            //var usuarioId = User.FindFirstValue("sub");
            //var usuarioActual = ObtenerUsuarioActual(usuarioId);

            //if (usuarioActual.Role != "Admin")
            //{
            //        return NotFound("No tenes los permisos para ver los usuarios");
            //}
            var usuarios = _repository.GetUsuarios();
            var usuariosDTO = _mapper.Map<List<UsuariosDTO>>(usuarios);
            return Ok(usuariosDTO);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetUsuarios(int id)
        {
            var usuario = _repository.GetUsuarios(id);
            if (usuario is null)
            {
                return NotFound("El usuario no existe");
            }
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

            if (usuarioActual.Role != "Admin")
            {
                if (usuarioActual.Id != id)
                    return NotFound("No tenes los permisos para ver este usuario");

            }

          

            //var compras = _ComprasRepository.GetComprasByUsuarioId(id);
            //var comprasDTO = _mapper.Map<ICollection<CompraSinUserDTO>>(compras);
            //if (comprasDTO.Count > 0)
            //{
            //    usuario.Compras = comprasDTO;
                
            //    return Ok(usuario);
            //}

            return Ok(_mapper.Map<UsuariosDTO>(usuario));
        }

        [HttpGet("ObtenerUsuario")]
        [Authorize]
        public IActionResult GetUsuariosToken()
        {

            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);

         
            return Ok(_mapper.Map<UsuariosDTO>(usuarioActual));
           
        }


        [HttpPost("authenticate")] //Vamos a usar un POST ya que debemos enviar los datos para hacer el login
        public ActionResult<string> Autenticar(UsuariosLoginDTO usuario) //Enviamos como parámetro la clase que creamos arriba
        {
            ////Paso 1: Validamos las credenciales
            var user = ValidateCredentials(usuario); //Lo primero que hacemos es llamar a una función que valide los parámetros que enviamos.

            if (user is null) //Si el la función de arriba no devuelve nada es porque los datos son incorrectos, por lo que devolvemos un Unauthorized (un status code 401).
                return Unauthorized("Usuario o Contraseña incorrectas");

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
                return NotFound("No tenes los permisos para craer un usuario");
            }
            if (_repository.ExisteNombreUsuario(usuarioACrear.Nombre))
            {
                return BadRequest("El nombre de usuario ya existe.");
            }

            
            if (_repository.ExisteEmail(usuarioACrear.Email))
            {
                return BadRequest("El correo electrónico ya existe.");
            }

            EUsuarios UsuarioNuevo = _mapper.Map<EUsuarios>(usuarioACrear);

            _repository.AgregarUsuario(UsuarioNuevo);
            _repository.GuardarCambios();

            return Ok();
        }

    

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult EditarNombreUsuarioAdmin(int id, [FromBody] EditarNombreUsuarioDTO nombreUsuarioDto)
        {
            var usuario = _repository.GetUsuarios(id);
            if (usuario is null)
            {
                return NotFound("El usuario no existe");
            }

            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                if (usuarioActual.Id != id)
                    return NotFound("No tenes los permisos para editar este usuario");

            }

           

            usuario.Nombre = nombreUsuarioDto.Nombre;
            _repository.GuardarCambios();

            return Ok("Nombre editado correctamente");
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
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin")
            {
                return NotFound("No tenes los permisos para eliminar este usuario");
            }

             _ProductoRepository.EliminarPuntoUser(idUsuario);
            

            // Eliminar las compras asociadas al usuario
            _ComprasRepository.EliminarCompraUser(idUsuario);


            _repository.EliminarUsuario(usuarioAEliminar);
            _repository.GuardarCambios();

            return NoContent();

        }




    }
}

