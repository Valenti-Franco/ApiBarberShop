using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class ECompras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public EUsuarios Usuario { get; set; }



        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        public EProducto Producto { get; set; }

        public string Estado { get; set; } = "Pendiente";

        public int Cantidad { get; set; }

        public DateTime FechaPublicado { get; private set; }

        public ECompras()
        {
            
            FechaPublicado = DateTime.Now;
        }


    }
}