namespace TpiBarberShop.Models.Responses
{
    public class AutorizationResponseData
    {
        public string scope { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string app_id { get; set; }
        public string expires_in { get; set; }
        public List<string> supported_authn_schemes { get; set; }
        public string nonce { get; set; }
        public string client_metadata { get; set; }

    }
}
