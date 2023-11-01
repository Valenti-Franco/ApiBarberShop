using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.Entities
{
    public class EPuntos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Range(1, 5, ErrorMessage = "El valor de Puntos debe estar entre 1 y 5")]
        public int Puntos { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;


        public int UsuarioId { get; set; }

        [ForeignKey("ProductoId")]
        public EProducto Producto { get; set; }
        public int ProductoId { get; set; }

        public DateTime FechaPublicado { get; private set; }


        public EPuntos(int puntos)
        {
            Puntos = puntos;
            FechaPublicado = DateTime.Now;

        }


    }
}
