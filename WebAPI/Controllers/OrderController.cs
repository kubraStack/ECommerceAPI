using Application.Features.Order.Commands.CreateOrder;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("order/create-order")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand createOrderCommand)
        {
            var result = await _mediator.Send(createOrderCommand);
            return Ok(result);
        }
    }
}
