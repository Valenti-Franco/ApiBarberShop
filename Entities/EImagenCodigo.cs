using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class EImagenCodigo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("CodigoId")]
        public int CodigoId { get; set; }

        public ECodigoDescuento codigo { get; set; }


        public string URL { get; set; }

        public DateTime FechaPublicado { get; private set; }

        public EImagenCodigo()
        {

            FechaPublicado = DateTime.Now;
        }
    }
}
