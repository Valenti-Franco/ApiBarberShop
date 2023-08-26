using AutoMapper;
using TpiBarberShop.DTOs;
using TpiBarberShop.Entities;

namespace TpiBarberShop.AutoMapper
{ 
        public class CategoryProfile1 : Profile
    {
        public CategoryProfile1()
        {
            CreateMap<Entities.ECategory, CategoryDTO>();
            CreateMap<DTOs.CategoryDTO, Entities.ECategory>();



            CreateMap<DTOs.CategoryActualizarDTO, Entities.ECategory>();

       



        }

    }
}
