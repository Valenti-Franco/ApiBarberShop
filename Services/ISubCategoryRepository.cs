using TpiBarberShop.DTOs.SubCategoria;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface ISubCategoryRepository
    {
        public IEnumerable<SubcategoryDTO> GetSubCategory();
        public ESubcategory GetSubCategory(int id);
        bool GuardarCambios();

        void AgregarSubCategory(ESubcategory subcategoryNuevo);
        void EliminarSubCategory(ESubcategory subcategory);
    }
}
