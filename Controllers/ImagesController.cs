using AutoMapper;
using AutoMapper.Internal;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Security.Cryptography;
using TpiBarberShop.DTOs.Imagen;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;


namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/Imagenes")]
    public class ImagesController : Controller
    {
        private readonly IImagesRepository _ImagesRepository;
        private readonly IMapper _mapper;

        public ImagesController(IImagesRepository ImagesRepository, IMapper mapper)
        {

            _ImagesRepository = ImagesRepository;
            _mapper = mapper;
        }
        [HttpGet("ImagenesUsuarios")]

        public IActionResult GetImagesUser()
        {
            var imagesUser = _ImagesRepository.GetImageUsuario();
            return Ok(imagesUser);


        }

        [HttpGet("ImagenesProducto")]

        public IActionResult GetImagesProducto()
        {
            var imagesUser = _ImagesRepository.GetImagesProducto();
            return Ok(imagesUser);


        }



        [HttpGet("ImagenesUsuarios/{idUsuario}")]

        public IActionResult GetImagesUser(int idUsuario)
        {
            var imagesUser = _ImagesRepository.GetImageUsuario(idUsuario);
            return Ok(_mapper.Map<ImagesUsuarioDTO>(imagesUser));


        }
        [HttpGet("ImagenesProducto/{idProducto}")]

        public IActionResult GetImagesProducto(int idProducto)
        {
            var imagesProducto = _ImagesRepository.GetImagesProducto(idProducto);
            return Ok(imagesProducto);


        }
        [HttpPost("Usuario")]
        public async Task<IActionResult> CrearImagen(ImageUsuarioCrearDTO imagenCrear)
        {
            if (!ValidarTamanioBase64(imagenCrear.Base64))
            {
                return BadRequest("El tamaño del archivo Base64 excede el límite de 1 MB.");
            }

            // Verificar si ya existe una imagen para el usuario con el mismo id
            var imagenExistente = _ImagesRepository.GetImageUsuario(imagenCrear.UsuarioId);

            if (imagenExistente != null)
            {
                // Actualizar los datos de la imagen existente
                imagenExistente.URL = await Upload(imagenCrear.Base64);
                _ImagesRepository.ActualizarImagenUsuario(imagenExistente);
                _ImagesRepository.GuardarCambios();

                var imagesUsuarioDTO = _mapper.Map<ImagesUsuarioDTO>(imagenExistente);
                return Ok(imagesUsuarioDTO);
            }
            else
            {
                // Si no existe, crear una nueva imagen
                EImagenUsuario imagenNueva = _mapper.Map<EImagenUsuario>(imagenCrear);
                imagenNueva.URL = await Upload(imagenCrear.Base64);
                _ImagesRepository.AgregarImagenUsuario(imagenNueva);
                _ImagesRepository.GuardarCambios();

                var imagesUsuarioDTO = _mapper.Map<ImagesUsuarioDTO>(imagenNueva);
                return Ok(imagesUsuarioDTO);
            }
        }

        [HttpPost("Producto")]
        public async Task<IActionResult> CrearImagenProducto(ImageProductoCrearDTO imagenCrear)
        {
            if (!ValidarTamanioBase64(imagenCrear.Base64))
            {
                return BadRequest("El tamaño del archivo Base64 excede el límite de 1 MB.");
            }

                EImagenProducto imagenNueva = _mapper.Map<EImagenProducto>(imagenCrear);
                imagenNueva.URL = await Upload(imagenCrear.Base64);
                _ImagesRepository.AgregarImagenProducto(imagenNueva);
                _ImagesRepository.GuardarCambios();

                var imagesProductoDTO = _mapper.Map<ImagesProductoDTO>(imagenNueva);
                return Ok(imagesProductoDTO);
            
        }

        [HttpDelete("{idUsuario}")]
        public ActionResult EliminarImagen(int idUsuario)
        {


            var imagenAEliminar = _ImagesRepository.GetImageUsuario(idUsuario);
            if (imagenAEliminar is null)
                return NotFound();

            _ImagesRepository.EliminarImagesUsuario(imagenAEliminar);
            _ImagesRepository.GuardarCambios();

            return NoContent();

        }

        private async Task<string> Upload(string base64)
        {
            Account account = new Account(
            "deh35rofi",
            "851565193999297",
            "okTgC9sBaBCwulxLUZTpnMOEnJE");

            Cloudinary cloudinary = new Cloudinary(account);
            cloudinary.Api.Secure = true;
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(Guid.NewGuid().ToString(), new MemoryStream(Convert.FromBase64String(base64)))
            };
            var response = await cloudinary.UploadAsync(uploadParams);
            return response.SecureUrl.AbsoluteUri;

        }

        private bool ValidarTamanioBase64(string base64String)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64String);
                int maxSizeInBytes =  1024 * 1024; // 2 MB
                return bytes.Length <= maxSizeInBytes;
            }
            catch (FormatException)
            {
             
                return false;
            }
        }
  






    }
}
