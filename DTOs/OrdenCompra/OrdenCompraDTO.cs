using System.ComponentModel.DataAnnotations.Schema;
using TpiBarberShop.DTOs.Detalle;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs.OrdenCompra
{
    public class OrdenCompraDTO
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }


        public IList<DetalleCompraDTO> DetalleCompra { get; set; }

        public string Estado { get; set; }

        public int Total
        {
            get
            {
                int precioTotal = 0;

                // Itera a través de los detalles de compra y suma los precios totales
                foreach (var detalle in DetalleCompra)
                {
                    precioTotal += detalle.PrecioTotal;
                }

                return precioTotal;
            }
        }
    }
}
