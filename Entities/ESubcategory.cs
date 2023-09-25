using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class ESubcategory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public ECategory Category { get; set; }

        public ICollection<EProducto> Producto { get; set; }

        public DateTime FechaPublicado { get; private set; }


        public ESubcategory(string nombre)
        {
            Nombre = nombre;
            FechaPublicado = DateTime.Now;

        }
    }
}
