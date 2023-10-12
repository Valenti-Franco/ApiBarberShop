namespace TpiBarberShop.Entities
{
    public class EMedioPago
    {
        public int id { get; set; }

        public string Tipo { get; set; }

        public string Titular { get; set; }

        public int NumeroTarjeta { get; set; }

        public DateTime FechaVen { get; set;}


        public EMedioPago(string titular)
        {
            Titular = titular;
        }


    }
}
