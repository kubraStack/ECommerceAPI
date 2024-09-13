using Application.Features.Customer.Queries.QueryByAdmin.GetAll;
using Application.Features.Customer.Queries.QueryByAdmin.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("admin/customers")]
        public async Task<IActionResult> GetAllCustomer()
        {
            var query = new GetAllCustomerQuery();
            var response = await _mediator.Send(query);

            return Ok(response);
        }

        [HttpGet("admin/customer/{id}")]
        public async Task<IActionResult> GetCustomerById(int id) {

            var query = new GetByIdCustomerQuery { Id = id};
            var response = await _mediator.Send(query);
            return Ok(response);

        
        }
       
    }
}
