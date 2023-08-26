using AutoMapper;
using TpiBarberShop.DTOs;

namespace TpiBarberShop.AutoMapper
{
    public class SubCategoryProfile : Profile
    {
        public SubCategoryProfile()
        {
            CreateMap<Entities.ESubcategory, SubcategoryDTO>();
            CreateMap<DTOs.SubCategoryActualizarDTO, Entities.ESubcategory>();


            CreateMap<Entities.ESubcategory, SubCategoryFilterDTO>();
            CreateMap<DTOs.SubCategoryFilterDTO, Entities.ESubcategory>();
        }

    }
}
