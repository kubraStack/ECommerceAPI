using Application.Features.User.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("user/[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllUserQuery userGetAllQuery)
        {
            var response = await _mediator.Send(userGetAllQuery);
            return Ok(response);
        }

    }
}
