using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class EImagenProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        public EProducto Producto { get; set; }

        public string URL { get; set; } = string.Empty;

        public DateTime FechaPublicado { get; private set; }

        public EImagenProducto()
        {

            FechaPublicado = DateTime.Now;
        }

    }
}
