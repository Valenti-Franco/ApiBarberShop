using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.DTOs.Usuario
{
    public class ResetPasswordDTO
    {
        [Required]
        public string Token { get; set; } = string.Empty;

        [Required, MinLength(6, ErrorMessage ="Porfavor agregar al menos 6 caracteres")]

        public string Password { get; set; } = string.Empty;


    }
}
