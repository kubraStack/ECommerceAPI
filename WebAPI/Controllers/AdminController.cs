using Application.Features.Customer.Commands.CreateCustomerRole;
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

       
       
        [HttpPost("assign-admin-role")]
        public async Task<IActionResult> CreateAdminRole(AdminRoleCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
       
    }
}
