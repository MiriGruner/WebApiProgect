using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servies;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;

        }
        [HttpPost]
        public async Task Post([FromBody] Order order)
        {
             await _orderService.CreateNewOrder(order);
            return;
        }
        }
}
