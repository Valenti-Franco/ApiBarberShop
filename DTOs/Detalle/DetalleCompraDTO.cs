using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TpiBarberShop.Entities;
using TpiBarberShop.DTOs.Producto;

namespace TpiBarberShop.DTOs.Detalle
{
    public class DetalleCompraDTO
    {

        public int Id { get; set; }

        public int OrdenCompraId { get; set; }

        public int Cantidad { set; get; }

        public ProductoPrecioDTO Producto { get; set; }



        public int PrecioTotal
        {
            get
            {
                int PrecioTotal = 0;

                PrecioTotal += Producto.Precio * Cantidad;

                return PrecioTotal;
            }
        }

    }
}
