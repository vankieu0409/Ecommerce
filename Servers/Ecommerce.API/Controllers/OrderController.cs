using Ecommerce.API.ViewModels;
using Ecommerce.Application.Interfaces.IServices;

using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderService orderService, ILogger<OrderController> logger)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger)); ;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderViewModel viewModel)
        {
            await _orderService.CreateOrder(viewModel.ToDto());
            return Ok();
        }

    }
}
