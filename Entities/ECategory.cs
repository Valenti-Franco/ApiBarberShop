using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class ECategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public ICollection<ESubcategory> SubCategory { get; set; }

        public DateTime FechaPublicado { get; private set; }


        public ECategory(string nombre)
        {
            Nombre = nombre;
            FechaPublicado = DateTime.Now;

        }

    }
}
