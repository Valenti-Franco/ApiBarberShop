using AutoMapper;
using TpiBarberShop.DTOs.Categoria;
using TpiBarberShop.Entities;

namespace TpiBarberShop.AutoMapper
{
    public class CategoryProfile1 : Profile
    {
        public CategoryProfile1()
        {
            CreateMap<Entities.ECategory, CategoryDTO>();
            CreateMap<CategoryDTO, Entities.ECategory>();



            CreateMap<CategoryActualizarDTO, Entities.ECategory>();

       



        }

    }
}
