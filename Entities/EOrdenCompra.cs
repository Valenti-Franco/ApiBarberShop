using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class EOrdenCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public EUsuarios Usuario { get; set; }



        public ICollection<EDetalleCompra> DetalleCompra { get; set; }


        public string Estado { get; set; }

        public string pagoId { get; set; }

        public string clientePaypalId { get; set; }

        public string valorPago { get; set; }

        public DateTime fechaPago { get; set; }

        public DateTime FechaPublicado { get; private set; }

        public EOrdenCompra()
        {

            FechaPublicado = DateTime.Now;
        }
    }
}
