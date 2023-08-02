using System.ComponentModel.DataAnnotations.Schema;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs
{
    public class CompraDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        //public EUsuarios Usuario { get; set; }
        public int ProductoId { get; set; }
        public ProductoSinPuntoDTO Producto { get; set; }
        public string? Estado { get; set; } = "Pendiente";
    }
}
