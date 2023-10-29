using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs.SubCategoria
{
    public class SubcategoryDTO
    {

        public int Id { get; set; }


        public string Nombre { get; set; }

        public int CategoryId { get; set; }

        public DateTime FechaPublicado { get; set; }


    }
}
