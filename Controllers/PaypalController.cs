using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MercadoPago.Resource.Payment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using TpiBarberShop.DTOs.Compra;
using TpiBarberShop.DTOs.Imagen;
using TpiBarberShop.DTOs.Paypal;
using TpiBarberShop.Entities;
using TpiBarberShop.Models;
using TpiBarberShop.Models.Paypal;
using TpiBarberShop.Services;

public class PaypalController : Controller
{
 
    private readonly IComprasRepository _ComprasRepository;


    private readonly IMapper _mapper;
    public PaypalController( IComprasRepository ComprasRepository, IMapper mapper)
    {
        
        _ComprasRepository = ComprasRepository;
        _mapper = mapper;
    }

    [HttpPost("Transaction")]
    public async Task<ActionResult> Transaction(string token, int compraId)
    {
        bool status = false;

        var compra = _ComprasRepository.GetCompras(compraId);
      
        if (compra == null)
        {
            return NotFound("No existe esa Compra");
        }

        if (compra.Estado == "confirmada")
        {
            return BadRequest("La compra ya está confirmada");
        }

        using (var client = new HttpClient())
        {
            var userName = "Ac3MzJjYMlf9KPvWHC-StBlKjaN3c56NJFOXQR07WUdmQTl1fPlEgYReQkZ7NaS7gSqbrFrkBaEx3LkT";
            var passwd = "EHSF1UGO01Xi0DXBXuRotjTSEyUXC7ZofnP2Yw7xJdIhASAvXGFoSThR6fPl2rmPPcazYdJUMBhdO4PF";

            client.BaseAddress = new Uri("https://api-m.sandbox.paypal.com");

            var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));


         

            
            var data = new StringContent("{}", Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync($"/v2/checkout/orders/{token}/capture", data);

            status = response.IsSuccessStatusCode;


            if (status)
            {
                var jsonRespuesta = response.Content.ReadAsStringAsync().Result;

                PaypalTransaction objeto = JsonConvert.DeserializeObject<PaypalTransaction>(jsonRespuesta);

                var paymentsId = objeto.purchase_units[0].payments.captures[0].id;

                var clientId = objeto.payer.payer_id;

                var paymentsValue = objeto.purchase_units[0].payments.captures[0].amount.value;

                var FechaPago = objeto.purchase_units[0].payments.captures[0].create_time;

                compra.pagoId = paymentsId;

                compra.clientePaypalId = clientId;

                compra.valorPago = paymentsValue;

                compra.fechaPago = FechaPago;

                _ComprasRepository.GuardarCambios();



                return Ok(compra);



            }

            return  NotFound("error");


        }


    }


[HttpPost("Paypal")]
    //public async Task<JsonResult> Paypal(PaypalDTO paypaldto)
    public async Task<ActionResult> Paypal(int compraId)

    {
        var compras = _ComprasRepository.GetCompras(compraId);
        var compra = _mapper.Map<CompraDTO>(compras);
        if (compra == null)
        {
            return NotFound("No existe esa Compra");
        }

        if (compra.Estado == "confirmada")
        {
            return BadRequest("La compra ya está confirmada");
        }
        string totalAsString = compra.Total.ToString();
        bool status = false;
        string respuesta = string.Empty;

        using (var client = new HttpClient())
        {
            var userName = "Ac3MzJjYMlf9KPvWHC-StBlKjaN3c56NJFOXQR07WUdmQTl1fPlEgYReQkZ7NaS7gSqbrFrkBaEx3LkT";
            var passwd = "EHSF1UGO01Xi0DXBXuRotjTSEyUXC7ZofnP2Yw7xJdIhASAvXGFoSThR6fPl2rmPPcazYdJUMBhdO4PF";

            client.BaseAddress = new Uri("https://api-m.sandbox.paypal.com");

            var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));


            var orden = new PaypalOrder()
            {
                intent = "CAPTURE",
                purchase_units = new List<TpiBarberShop.Models.Paypal.PurchaseUnit>() {
       new TpiBarberShop.Models.Paypal.PurchaseUnit()
       {
            amount = new TpiBarberShop.Models.Paypal.Amount() {
          currency_code= "USD",
          value= totalAsString
       }

        },
		//"description":"Pruducto de pruebas"
      },
                application_context = new ApplicationContext()
                {
                    brand_name = "NavajaFina.com",
                    landing_page = "NO_PREFERENCE",
                    return_url = $"http://localhost:3000?compraId={compraId}",
                    cancel_url = "http://localhost:3000"

                }
            };

            var json = JsonConvert.SerializeObject(orden);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/v2/checkout/orders", data);

            status = response.IsSuccessStatusCode;


            if (status)
            {
                respuesta = response.Content.ReadAsStringAsync().Result;

            }


            return Ok(respuesta);

        }


    }
}

//[HttpGet("ProcesarPago")]
//public async Task<IActionResult> ProcesarPago()
//{
//    // Call the GetAuthotizationRequest method from PayPalClientApi
//    var authorizationResponse = await _payPalClientApi.GetAuthotizationRequest();

//    // You can handle the response as needed
//    if (authorizationResponse != null)
//    {
//        // Process the authorizationResponse here
//        // For example, you can return it as JSON
//        return Json(authorizationResponse);
//    }
//    else
//    {
//        // Handle the case where authorizationResponse is null
//        return BadRequest("Failed to obtain authorization.");
//    }
//}