using TpiBarberShop.DTOs.SubCategoria;

namespace TpiBarberShop.DTOs.Categoria
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }

        public DateTime FechaPublicado { get; set; }


        public List<SubCategoryFilterDTO> SubCategory { get; set; } = new List<SubCategoryFilterDTO>();
    }
}
