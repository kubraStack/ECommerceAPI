using Application.Features.User.Commands.ChangePassword.Commands;
using Application.Features.User.Commands.Delete;
using Application.Features.User.Commands.Update;
using Application.Features.User.Commands.UpdateByAdmin;
using Application.Features.User.Queries.GetAll;
using Application.Features.User.Queries.GetByIdSelf;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("user/settings")]
        public async Task<IActionResult> GetByIdSelf([FromQuery] GetByIdUserSelfQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }



        [HttpGet("user/[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllUserQuery userGetAllQuery)
        {
            var response = await _mediator.Send(userGetAllQuery);
            return Ok(response);
        }

        [HttpPut("user/update")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand updateUserCommand)
        {
            var result = await _mediator.Send(updateUserCommand);
            return Ok(result);
        }

        [HttpPut("user/update-byAdmin")]
        public async Task<IActionResult> UpdateUserByAdmin([FromBody] UpdateUserByAdminCommand updateUserByAdminCommand)
        {
            var result = await _mediator.Send(updateUserByAdminCommand);
            return Ok(result);

        }

        [HttpDelete("user/delete/{Id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] DeleteUserCommand deleteUsercommand) 
        { 
            var response = await _mediator.Send(deleteUsercommand);
            return Ok(response);
        
        }

        //Change Password
        [HttpPut("user/ChangePassword")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordCommand changePasswordCommand)
        {
            var result = await _mediator.Send(changePasswordCommand);
            return Ok(result.Message);
        }

    }
}
