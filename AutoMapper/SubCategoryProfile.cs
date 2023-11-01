using AutoMapper;
using TpiBarberShop.DTOs.SubCategoria;

namespace TpiBarberShop.AutoMapper
{
    public class SubCategoryProfile : Profile
    {
        public SubCategoryProfile()
        {
            CreateMap<Entities.ESubcategory, SubcategoryDTO>();
            CreateMap<SubCategoryActualizarDTO, Entities.ESubcategory>();


            CreateMap<Entities.ESubcategory, SubCategoryFilterDTO>();
            CreateMap<SubCategoryFilterDTO, Entities.ESubcategory>();
        }

    }
}
