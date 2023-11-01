using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TpiBarberShop.DBContexts;
using TpiBarberShop.DTOs.SubCategoria;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public SubCategoryRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AgregarSubCategory(ESubcategory subcategoryNuevo)
        {
            _context.SubCategory.Add(subcategoryNuevo);
        }


        public void EliminarSubCategory(ESubcategory subcategory)
        {
            _context.SubCategory.Remove(subcategory);
        }

        public IEnumerable<SubcategoryDTO> GetSubCategory()
        {
            var subcategory = _context.SubCategory.OrderBy(u => u.Nombre).ToList();
            var subcategoryDto = _mapper.Map<List<SubcategoryDTO>>(subcategory);

            return subcategoryDto;
        }

        public ESubcategory GetSubCategory(int id)
        {
            return _context.SubCategory
         .Where(p => p.Id == id)
         .FirstOrDefault();
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }

      
    }
}
