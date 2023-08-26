using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/SubCategory")]
    public class SubcategoryController : Controller
    {
        private readonly ISubCategoryRepository _SubCategoryRepository;

        private readonly IMapper _mapper;
        public SubcategoryController(ISubCategoryRepository SubCategoryRepository, IMapper mapper)
        {
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

        [HttpPut("{id}")]

        public IActionResult ActualizarSubCategory(int id, [FromBody] SubCategoryActualizarDTO subcategoryActualizada)
        {


            var subcategoryAActualizar = _SubCategoryRepository.GetSubCategory(id);

            if (subcategoryAActualizar == null)
            {
                return NotFound("No se encontró la subcategoría");
            }

            _mapper.Map(subcategoryActualizada, subcategoryAActualizar);
            _SubCategoryRepository.GuardarCambios();

            return Ok("Subcategoria editado correctamente");
        }

        [HttpPost]

        public ActionResult<SubcategoryDTO> CreacionPunto(SubCategoryActualizarDTO subcategoryACrear)
        {


            ESubcategory SubCategoryNuevo = _mapper.Map<ESubcategory>(subcategoryACrear);

            _SubCategoryRepository.AgregarSubCategory(SubCategoryNuevo);
            _SubCategoryRepository.GuardarCambios();

            return Ok(_mapper.Map<SubcategoryDTO>(SubCategoryNuevo));
        }



        [HttpDelete("{idSubCategory}/Admin")]

        public ActionResult EliminarProductoAdmin(int idSubCategory)
        {


            var subcategoryAEliminar = _SubCategoryRepository.GetSubCategory(idSubCategory);
            if (subcategoryAEliminar is null)
                return NotFound("No se encontro la Subcategoria");

            _SubCategoryRepository.EliminarSubCategory(subcategoryAEliminar);
            _SubCategoryRepository.GuardarCambios();

            return NoContent();

        }


    }
}
