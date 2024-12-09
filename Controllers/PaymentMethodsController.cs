using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace YalabenaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly string _payMobApiKey = "ZXlKaGJHY2lPaUpJVXpVeE1pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SmpiR0Z6Y3lJNklrMWxjbU5vWVc1MElpd2ljSEp2Wm1sc1pWOXdheUk2TVRBd056a3lPU3dpYm1GdFpTSTZJbWx1YVhScFlXd2lmUS5ERUVZVmk4cDAyLVY1V0tidDE2NDBGekN1dlBYN2VIMjhHZGItaXYtYnBxSjdVU3FsSl9fcTdISXFaTW5fSlhXUzRhN1dCa051OGRzNXVrWVN0WXh2QQ=="; // Replace with your PayMob API key
        private readonly string _payMobAuthUrl = "https://accept.paymobsolutions.com/api/auth/tokens";
        private readonly string _payMobOrderUrl = "https://accept.paymobsolutions.com/api/ecommerce/orders";
        private readonly string _payMobPaymentUrl = "https://accept.paymobsolutions.com/api/acceptance/payment_keys";

        [HttpPost("create-payment")]
        public async Task<IActionResult> CreatePayment([FromBody] PaymentRequest request)
        {
            // Step 1: Authenticate and get the token from PayMob
            var authToken = await AuthenticatePayMob();

            // Step 2: Create an order
            var order = await CreateOrder(authToken, request.Amount);

            // Step 3: Generate payment token for redirecting to the payment page
            var paymentToken = await GeneratePaymentToken(authToken, order);

            // Return payment token to frontend to redirect user to PayMob payment page
            return Ok(new { payment_url = $"https://accept.paymobsolutions.com/api/acceptance/iframes/{paymentToken}" });
        }

        private async Task<string> AuthenticatePayMob()
        {
            using (var client = new HttpClient())
            {
                var requestContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    api_key = _payMobApiKey
                }), Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_payMobAuthUrl, requestContent);
                var responseData = await response.Content.ReadAsStringAsync();
                var authResponse = JsonConvert.DeserializeObject<AuthResponse>(responseData);
                return authResponse.token;
            }
        }

        private async Task<OrderResponse> CreateOrder(string authToken, decimal amount)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");

                var requestContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    amount_cents = amount * 100, // PayMob expects the amount in cents
                    currency = "EGP",
                    merchant_order_ext_ref = Guid.NewGuid().ToString()
                }), Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_payMobOrderUrl, requestContent);
                var responseData = await response.Content.ReadAsStringAsync();
                var orderResponse = JsonConvert.DeserializeObject<OrderResponse>(responseData);
                return orderResponse;
            }
        }

        private async Task<string> GeneratePaymentToken(string authToken, OrderResponse order)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");

                var requestContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    amount_cents = order.amount_cents,
                    currency = "EGP",
                    order_id = order.id,
                    integration_id = "YOUR_INTEGRATION_ID", // Replace with your integration ID
                    lock_order_when_paid = true
                }), Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_payMobPaymentUrl, requestContent);
                var responseData = await response.Content.ReadAsStringAsync();
                var paymentResponse = JsonConvert.DeserializeObject<PaymentResponse>(responseData);
                return paymentResponse.payment_key;
            }
        }
    }

    public class PaymentRequest
    {
        public decimal Amount { get; set; }
    }

    public class AuthResponse
    {
        public string token { get; set; }
    }

    public class OrderResponse
    {
        public string id { get; set; }
        public long amount_cents { get; set; }
    }

    public class PaymentResponse
    {
        public string payment_key { get; set; }
    }
}
