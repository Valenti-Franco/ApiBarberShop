using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;
using TpiBarberShop.Services;

namespace TpiBarberShop.Controllers
{
    [ApiController]
    [Route("api/Category")]
    public class CategoryController : Controller
    {

        private readonly ICategoryRepository _CategoryRepository;

        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepository CategoryRepository, IMapper mapper)
        {
            _CategoryRepository = CategoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProductos()
        {
            var category = _CategoryRepository.GetCategory();
            return Ok(category);


        }

        [HttpGet("{id}")]
        public IActionResult GetProductos(int id)
        {
            var category = _CategoryRepository.GetCategory(id);

            if (category == null)
            {
                return NotFound("No se encontró la categoría");
            }
            return Ok(_mapper.Map<CategoryDTO>(category));


        }

        [HttpPut("{id}")]

        public IActionResult ActualizarCategory(int id, [FromBody] CategoryActualizarDTO categoryActualizada)
        {


            var categoryAActualizar = _CategoryRepository.GetCategory(id);

            if (categoryAActualizar == null)
            {
                return NotFound("No se encontró la categoría");
            }

            _mapper.Map(categoryActualizada, categoryAActualizar);
            _CategoryRepository.GuardarCambios();

            return Ok("Categoria editado correctamente");
        }

        [HttpPost]
        
        public ActionResult<CategoryDTO> CreacionPunto(CategoryActualizarDTO categoryACrear)
        {
           

            ECategory CategoryNuevo = _mapper.Map<ECategory>(categoryACrear);

            _CategoryRepository.AgregarCategory(CategoryNuevo);
            _CategoryRepository.GuardarCambios();

            return Ok(_mapper.Map<CategoryDTO>(CategoryNuevo));
        }



        [HttpDelete("{idCategory}/Admin")]
      
        public ActionResult EliminarProductoAdmin(int idCategory)
        {

          
            var categoryAEliminar = _CategoryRepository.GetCategory(idCategory);
            if (categoryAEliminar is null)
                return NotFound("No se encontro la categoria");

            _CategoryRepository.EliminarCategory(categoryAEliminar);
            _CategoryRepository.GuardarCambios();

            return NoContent();

        }

    }
}
