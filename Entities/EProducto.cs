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

        

        public string? Descripcion { get; set; }

        public ICollection<EPuntos> Puntos { get; set; }

        public EProducto(string nombre)
        {
            Nombre = nombre;
        }
    }
}
