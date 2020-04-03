using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;

namespace UserService
{
    public class OrderDetailsProvider
    {
        public static async Task<OrderDetails> GetData()
        {
            List<Order> orders;
            User user;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:32768/orders"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    orders = JsonConvert.DeserializeObject<List<Order>>(apiResponse);
                }
                using (var response = await httpClient.GetAsync("https://localhost:32772/user/1"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<User>(apiResponse);
                }
                return new OrderDetails { Orders = orders, User = user };
            }
        }
    }
}
