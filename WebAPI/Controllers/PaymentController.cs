using Application.Features.Payment.Commands.CreatePayment;
using Application.Features.Payment.Commands.DeletePayment;
using Application.Features.Payment.Commands.UpdatePayment;
using Application.Features.Payment.Queries.GetPaymentsByOrderId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/Payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreatePayment")]
        public async Task<IActionResult> CreatePayment([FromBody] CreatePaymentCommand createPaymentCommand)
        {
            var result = await _mediator.Send(createPaymentCommand);
            return Ok(result);
        }

        [HttpPut("UpdatePayment/{paymentId}")]
        public async Task<IActionResult> UpdatePayment(int paymentId, [FromBody] UpdatePaymentCommand updatePaymentCommand)
        {
            updatePaymentCommand.PaymentId = paymentId;
            var response = await _mediator.Send(updatePaymentCommand);
            return Ok(response);
        }

        [HttpDelete("DeletePayment/{paymentId}")]
        public async Task<IActionResult> DeletePayment(int paymentId)
        {
            var command = new DeletePaymentCommand { PaymentId = paymentId };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("GetPaymentsByOrderId/{orderId}")]
        public async Task<IActionResult> GetPaymentsByOrderId(int orderId)
        {
            var query = new GetPaymentByOrderIdQuery(orderId);
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
