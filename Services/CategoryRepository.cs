using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs.Categoria;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public CategoryRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AgregarCategory(ECategory categoryNuevo)
        { 
              _context.Category.Add(categoryNuevo);
 
        }

        public void EliminarCategory(ECategory category)
        {
            _context.Category.Remove(category);
        }

        public ECategory GetCategory(int id)
        {
            return _context.Category
         .Where(p => p.Id == id)
         .Include(p => p.SubCategory) // Incluir subcategorías en la consulta
         .FirstOrDefault();

     



        }

        public IEnumerable<CategoryDTO> GetCategory()
        {
            var category = _context.Category.OrderBy(u => u.Nombre).Include(p => p.SubCategory).ToList();
            var categoryDto = _mapper.Map<List<CategoryDTO>>(category);

            return categoryDto;
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }
    }



}
