using System.ComponentModel.DataAnnotations.Schema;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs
{
    public class ImagesUsuarioDTO
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }


        public string URL { get; set; }
    }
}
