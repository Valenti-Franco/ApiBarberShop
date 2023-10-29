using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TpiBarberShop.DTOs;
using System.Security;

namespace TpiBarberShop.Entities
{
    public class EUsuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [MaxLength(150)]

        public string Email { get; set; }

        [Required]
        public string Role { get; set; }
        public EImagenUsuario Imagen { get; set; }
        public ICollection<ECompras> Compras { get; set; }
        public ICollection<EOrdenCompra> OrdenCompra { get; set; }


        public DateTime FechaPublicado { get; private set; }




        public string?  VerificationToken { get; set; }

        public DateTime? VerifiedAt { get; set; }

        public string? PasswordResetToken { get; set; }  

        public DateTime? ResetTokenExpires { get; set; } 







        public EUsuarios(string nombre)
        {
            Nombre = nombre;
            Role = "Cliente";
            FechaPublicado = DateTime.Now;

        }
    }
}
