using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class EDetalleCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        public EProducto Producto { get; set; }

        [ForeignKey("OrdenCompraId")]
        public int OrdenCompraId { get; set; }
        public EOrdenCompra OrdenCompra { get; set; }
        public int Cantidad { get; set; }

        public DateTime FechaPublicado { get; private set; }

        public EDetalleCompra()
        {

            FechaPublicado = DateTime.Now;
        }

    }
}
