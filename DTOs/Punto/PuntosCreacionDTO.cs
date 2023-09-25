using System.ComponentModel.DataAnnotations;

namespace TpiBarberShop.DTOs.Punto
{
    public class PuntosCreacionDTO
    {
        [Range(1, 5, ErrorMessage = "El valor de Puntos debe estar entre 1 y 5")]
        public decimal Puntos { get; set; }




    }
}
