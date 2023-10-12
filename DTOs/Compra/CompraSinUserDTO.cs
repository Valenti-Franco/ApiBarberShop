namespace TpiBarberShop.DTOs.Compra
{
    public class CompraSinUserDTO
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string? Estado { get; set; }
        public int Cantidad { get; set; }

        public string pagoId { get; set; }

        public string clientePaypalId { get; set; }

        public string valorPago { get; set; }

        public string fechaPago { get; set; }

    }
}
