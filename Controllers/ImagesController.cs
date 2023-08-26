using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using TpiBarberShop.DTOs;
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
        [HttpPost("Usuario")]
        public async Task<ImagesUsuarioDTO> CrearImagen(ImageUsuarioCrearDTO imagenCrear)
        {

            EImagenUsuario imagenNueva = _mapper.Map<EImagenUsuario>(imagenCrear);
          

            imagenNueva.URL = await Upload(imagenCrear.Base64);
            _ImagesRepository.AgregarImagenUsuario(imagenNueva);
            _ImagesRepository.GuardarCambios();

            return _mapper.Map<ImagesUsuarioDTO>(imagenNueva);
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

    }
}
