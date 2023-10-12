using System.ComponentModel.DataAnnotations.Schema;
using TpiBarberShop.DTOs.Producto;
using TpiBarberShop.Entities;

namespace TpiBarberShop.DTOs.Compra
{
    public class CompraDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        //public EUsuarios Usuario { get; set; }
        public int ProductoId { get; set; }
        public ProductoSinPuntoDTO Producto { get; set; }
        public string? Estado { get; set; } = "Pendiente";

        public int Cantidad { get; set; }

        public string pagoId { get; set; }

        public string clientePaypalId { get; set; }

        public string valorPago { get; set; }

        public string fechaPago { get; set; }

        public int Total
        {
            get
            {
                int sumaDePuntos = 0;
              
                  sumaDePuntos += Producto.Precio * Cantidad;
                
                return sumaDePuntos;
            }
        }

    }
}
