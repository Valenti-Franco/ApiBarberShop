using System.ComponentModel.DataAnnotations.Schema;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs
{
    public class OrdenCompraDTO
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }


        public IList<DetalleCompraDTO> DetalleCompra { get; set; }

        public string Estado { get; set; }
    }
}
