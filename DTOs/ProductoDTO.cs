using TpiBarberShop.DTOs;

namespace TpiBarberShop.DTOs
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public IList<PuntosDTO> Puntos { get; set; } = new List<PuntosDTO>();

        public int CantidadDePuntos
        {
            get { return Puntos.Count; }
        }
        public int SumaDePuntos
        {
            get
            {
                int sumaDePuntos = 0;
                foreach (var punto in Puntos)
                {
                    sumaDePuntos += punto.Puntos;
                }
                return sumaDePuntos;
            }
        }




    }
}
