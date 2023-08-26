using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TpiBarberShop.Entities
{
    public class EProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El Stock debe ser mayor a 1")]
        public int Stock { get; set; }


        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El Precio debe ser mayor a 1")]
        public int Precio { get; set; }

        public string? Descripcion { get; set; }

        public int CategoryId { get; set; }
        //public ECategory category { get; set; }
        public int SubcategoryId { get; set; }
        public ESubcategory Subcategory { get; set; }

        public ICollection<EImagenProducto> Imagenes { get; set; }
        public ICollection<EPuntos> Puntos { get; set; }
        public ICollection<ECompras> Compras { get; set; }
        public ICollection<EDetalleCompra> DetalleCompra { get; set; }

        public DateTime FechaPublicado { get; private set; }

        public EProducto(string nombre)
        {
            Nombre = nombre;
            FechaPublicado = DateTime.Now;
        }
    }
}
