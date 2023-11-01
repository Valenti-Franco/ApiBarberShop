using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TpiBarberShop.DTOs.SubCategoria;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/SubCategory")]
    public class SubcategoryController : Controller
    {
        private readonly ISubCategoryRepository _SubCategoryRepository;
        private readonly IProductosRepository _repository;


        private readonly IMapper _mapper;
        public SubcategoryController(ISubCategoryRepository SubCategoryRepository, IProductosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _SubCategoryRepository = SubCategoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProductos()
        {
            var subcategory = _SubCategoryRepository.GetSubCategory();
            return Ok(subcategory);


        }

        [HttpGet("{id}")]
        public IActionResult GetSubCategory(int id)
        {
            var subcategory = _SubCategoryRepository.GetSubCategory(id);

            if (subcategory == null)
            {
                return NotFound("No se encontró la Subcategoría");
            }
            return Ok(_mapper.Map<SubcategoryDTO>(subcategory));


        }

        [HttpPut("{id}/Admin")]
        [Authorize]
        public IActionResult ActualizarSubCategory(int id, [FromBody] SubCategoryActualizarDTO subcategoryActualizada)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin" && usuarioActual.Role != "Editor")

            {
                return Forbid("No tenes los permisos para editar esta Subcategoria");

            }
            
            var subcategoryAActualizar = _SubCategoryRepository.GetSubCategory(id);

            if (subcategoryAActualizar == null)
            {
                return NotFound("No se encontró la subcategoría");
            }

            _mapper.Map(subcategoryActualizada, subcategoryAActualizar);
            _SubCategoryRepository.GuardarCambios();

            return Ok("Subcategoria editado correctamente");
        }

        [HttpPost("Admin")]
        [Authorize]
        public ActionResult<SubcategoryDTO> CreacionPunto(SubCategoryActualizarDTO subcategoryACrear)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin" && usuarioActual.Role != "Editor")

            {

                return Forbid("No tenes los permisos para crear esta Subcategoria");

            }

            ESubcategory SubCategoryNuevo = _mapper.Map<ESubcategory>(subcategoryACrear);

            _SubCategoryRepository.AgregarSubCategory(SubCategoryNuevo);
            _SubCategoryRepository.GuardarCambios();

            return Ok(_mapper.Map<SubcategoryDTO>(SubCategoryNuevo));
        }



        [HttpDelete("{idSubCategory}/Admin")]
        [Authorize]
        public ActionResult EliminarProductoAdmin(int idSubCategory)
        {
            var usuarioId = User.FindFirstValue("sub");
            var usuarioActual = ObtenerUsuarioActual(usuarioId);
            if (usuarioActual.Role != "Admin" && usuarioActual.Role != "Editor")

            {

                return Forbid("No tenes los permisos para eliminar esta Subcategoria");

            }

            var subcategoryAEliminar = _SubCategoryRepository.GetSubCategory(idSubCategory);
            if (subcategoryAEliminar is null)
                return NotFound("No se encontro la Subcategoria");

            _SubCategoryRepository.EliminarSubCategory(subcategoryAEliminar);
            _SubCategoryRepository.GuardarCambios();

            return NoContent();

        }

        private EUsuarios ObtenerUsuarioActual(string usuarioId)
        {
            var usuario = _repository.GetUsuarios(int.Parse(usuarioId));

            return usuario;
        }
    }
}
