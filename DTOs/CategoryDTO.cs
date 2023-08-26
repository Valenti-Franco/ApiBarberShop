namespace TpiBarberShop.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }


        public List<SubCategoryFilterDTO> SubCategory { get; set; } = new List<SubCategoryFilterDTO>();
    }
}
