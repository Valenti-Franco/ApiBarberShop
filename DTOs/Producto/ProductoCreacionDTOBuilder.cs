namespace TpiBarberShop.DTOs.Producto
{
    public class ProductoCreacionDTOBuilder
    {
        private ProductoCreacionDTO productoCreacionDTO;

        public ProductoCreacionDTOBuilder()
        {
            productoCreacionDTO = new ProductoCreacionDTO();
        }

        public ProductoCreacionDTOBuilder WithNombre(string nombre)
        {
            productoCreacionDTO.Nombre = nombre;
            return this;
        }

        public ProductoCreacionDTOBuilder WithStock(int stock)
        {
            productoCreacionDTO.Stock = stock;
            return this;
        }

        public ProductoCreacionDTOBuilder WithPrecio(int precio)
        {
            productoCreacionDTO.Precio = precio;
            return this;
        }

        public ProductoCreacionDTOBuilder WithCategoryId(int categoryId)
        {
            productoCreacionDTO.CategoryId = categoryId;
            return this;
        }

        public ProductoCreacionDTOBuilder WithSubcategoryId(int subcategoryId)
        {
            productoCreacionDTO.SubcategoryId = subcategoryId;
            return this;
        }

        public ProductoCreacionDTOBuilder WithDescripcion(string descripcion)
        {
            productoCreacionDTO.Descripcion = descripcion;
            return this;
        }

        public ProductoCreacionDTO Build()
        {
            return productoCreacionDTO;
        }
    }

}
