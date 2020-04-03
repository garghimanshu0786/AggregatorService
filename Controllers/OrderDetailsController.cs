using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UserService
{
    [ApiController]
    [Route("orderdetails")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly ILogger<OrderDetailsController> _logger;

        public OrderDetailsController(ILogger<OrderDetailsController> logger)
        {
            _logger = logger;
        }

        [Route("{id}")]
        public OrderDetails GetOrderDetails(int id)
        {
            return OrderDetailsProvider.GetData().Result;
        }
    }
}
