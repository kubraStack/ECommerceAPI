using Application.Features.Customer.Commands.Update;
using Application.Features.Customer.Commands.UpdateByAdmin;
using Application.Features.Customer.Queries.GetByIdSelf;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Customer Ayarları
        [HttpGet("customer/settings")]
        public async Task<IActionResult> GetByIdSelf()
        {
            var query = new GetByIdCustomerSelfQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPut("customer/update")]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("admin/customer-update")]
        public async Task<IActionResult> UpdateCustomerByAdmin([FromBody] UpdateCustomerByAdminCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
