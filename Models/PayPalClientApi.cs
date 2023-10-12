using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using TpiBarberShop.Models.Responses;
using TpiBarberShop.Utils;

namespace TpiBarberShop.Models
{
    public class PayPalClientApi
    {
        private HttpClient _client;

        public PayPalClientApi()
        {
            CreateHttpClient();
        }

        private void CreateHttpClient()
        {
            _client = new HttpClient();
        }
        public async Task<AutorizationResponseData> GetAuthotizationRequest()
        {
            EnsureHttpClientCreated();
            var byteArray = Encoding.ASCII.GetBytes($"{ConfigHelper.ClientId}:{ConfigHelper.ClientSecret}");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(scheme: "Basic", parameter: Convert.ToBase64String(byteArray));

            var keyValueParis = new List<KeyValuePair<string, string>>
            { new KeyValuePair<string, string>("grant_type", "client_credentials") };

            var response = await _client.PostAsync($"{ConfigHelper.BaseUrl}/v1/oauth2/token", new FormUrlEncodedContent(keyValueParis));

            var responseAsString = await response.Content.ReadAsStringAsync();
            var authorizationResponse = JsonConvert.DeserializeObject<AutorizationResponseData>(responseAsString);

            return authorizationResponse;


        }
        private void EnsureHttpClientCreated()
            {
                if (_client == null)
                {
                    CreateHttpClient();
                }
           
        }
    }
}
