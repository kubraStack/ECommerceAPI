using Application.Features.OrderDetails.Commands.CreateOrderDetail;
using Application.Features.OrderDetails.Queries.GetByIdOrderDetail;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/OrderDetail")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create-OrderDetail")]
        public async Task<IActionResult> CreateOrderDetail([FromBody] CreateOrderDetailCommand createOrderDetailCommand)
        {
            var result = await _mediator.Send(createOrderDetailCommand);
            return Ok(result);
        }

        [HttpGet("GetById-OrderDetail/{id}")]
        public async Task<IActionResult> GetByIdOrderDetail(int id)
        {
            var query = new GetByIdOrderDetailQuery(id);
            var response = await _mediator.Send(query);
            return Ok(response);
        }

    }
}
