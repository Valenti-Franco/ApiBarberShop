using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace TpiBarberShop.Entities
{
    public class ECompras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public EUsuarios Usuario { get; set; }



        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        public EProducto Producto { get; set; }




        public string Estado { get; set; } = "Pendiente";

        public string pagoId { get; set; }

        public string clientePaypalId { get; set; }

        public string valorPago { get; set; }

        public DateTime fechaPago { get; set; }





        public int Cantidad { get; set; }

        public DateTime FechaPublicado { get; private set; }

        public ECompras()
        {

            FechaPublicado = DateTime.Now;
        }


    }
}