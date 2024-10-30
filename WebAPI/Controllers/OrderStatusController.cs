using Application.Features.Order.Queries.GetAllOrders;
using Application.Features.OrderStatus.Commands.CreateOrderStatusCommand;
using Application.Features.OrderStatus.Commands.DeleteOrderStatuscommand;
using Application.Features.OrderStatus.Commands.UpdateOrderStatusCommand;
using Application.Features.OrderStatus.Queries.GetAllOrderStatus;
using Application.Features.OrderStatus.Queries.GetByIdOrderStatus;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/OrderStatus")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create-OrderStatus")]
        public async Task<IActionResult> CreateOrderStatus([FromBody] CreateOrderStatusCommand orderStatusCommand) { 
            
            var result = await _mediator.Send(orderStatusCommand);
            return Ok(result);
        
        }

        [HttpGet("GelAll-OrderStatus")]
        public async Task<ActionResult<List<GetAllOrderStatusQueryResponse>>> GetAllOrderStatuses()
        {
            var query = new GetAllOrderStatusQuery();
            var result = await _mediator.Send(query);
            return Ok(result); 
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetByIdOrderStatus(int id) {

            var query = new GetByIdOrderStatusQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        
        }

        [HttpPut("Update-OrderStatus/{orderId}")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, [FromBody] UpdateOrderStatusCommand updateOrderStatusCommand)
        {
            updateOrderStatusCommand.OrderId = orderId;
            var response = await _mediator.Send(updateOrderStatusCommand);
            return Ok(
                new {
                    updatedStatus = response.NewStatusName,
                    message = response.Message
                }
            );
        }

        [HttpDelete("Delete-OrderStatus/{id}")]
        public async Task<ActionResult<DeleteOrderStatusCommandResponse>> DeleteOrderStatus(int id)
        {
            var command = new DeleteOrderStatusCommand(id);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
