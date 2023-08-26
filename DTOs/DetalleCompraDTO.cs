using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs
{
    public class DetalleCompraDTO
    {

        public int Id { get; set; }

        public int ProductoId { get; set; }

        public int OrdenCompraId { get; set; }

        public int Cantidad { set; get; }


    }
}
