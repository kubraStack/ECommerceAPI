using Application.Features.Payment.Commands.CreatePayment;
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
    }
}
