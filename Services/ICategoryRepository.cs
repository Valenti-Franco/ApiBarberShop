using Microsoft.AspNetCore.Mvc;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;

namespace TpiBarberShop.Services
{
    public interface ICategoryRepository
    {
        public IEnumerable<CategoryDTO> GetCategory();
        public ECategory GetCategory(int id);
        bool GuardarCambios();

        void AgregarCategory(ECategory categoryNuevo);
        void EliminarCategory(ECategory category);
    }
}
