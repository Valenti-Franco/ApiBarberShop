using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.DTOs
{
    public class PuntosActualizarDTO
    {
        [Range(1, 5, ErrorMessage = "El valor de Puntos debe estar entre 1 y 5")]
        public decimal Puntos { get; set; }


        

    }
}
