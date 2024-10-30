using Application.Features.OrderDetails.Commands.CreateOrderDetail;
using Application.Features.OrderDetails.Commands.DeleteOrderDetail;
using Application.Features.OrderDetails.Queries.GetAllOrderDetail;
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
        public async Task<IActionResult> CreateOrderDetails([FromBody] CreateOrderDetailCommand createOrderDetailCommand)
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
        [HttpGet("GetAll-OrderDetail")]
        public async Task<IActionResult> GetAllOrderDetails()
        {
            var query = new GetAllOrderDetailQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpDelete("Delete-OrderDetail{orderDetailId}")]
        public async Task<IActionResult> DeleteOrderDetails(int orderDetailId)
        {
            var command = new DeleteOrderDetailCommand(orderDetailId);
            var result = await _mediator.Send(command);
            return Ok(new { message = result.Message });
        }

    }
}
