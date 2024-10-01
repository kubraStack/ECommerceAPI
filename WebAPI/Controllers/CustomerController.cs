using Application.Features.Customer.Commands.AddFavoriteProduct;
using Application.Features.Customer.Commands.DeleteByAdmin;
using Application.Features.Customer.Commands.DeleteFavoriteProduct;
using Application.Features.Customer.Commands.Update;
using Application.Features.Customer.Commands.UpdateByAdmin;
using Application.Features.Customer.Queries.GetAllFavoriteProduct;
using Application.Features.Customer.Queries.GetByIdSelf;
using Application.Features.Customer.Queries.QueryByAdmin.GetAll;
using Application.Features.Customer.Queries.QueryByAdmin.GetById;
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

        [HttpGet("customers")]
        public async Task<IActionResult> GetAllCustomers([FromQuery] GetAllCustomerQuery getAllCustomerQuery)
        {
            var response = await _mediator.Send(getAllCustomerQuery);
            return Ok(response);
        }

        [HttpGet("customers/{Id}")]
        public async Task<IActionResult> GetByIdCustomer(int Id)
        {
            var query = new GetByIdCustomerQuery { Id = Id };
            var response = await _mediator.Send(query);
            return Ok(response);
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

        [HttpPut("customer/update-byAdmin")]
        public async Task<IActionResult> UpdateCustomerByAdmin([FromBody] UpdateCustomerByAdminCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("admin/customers/{Id}")]
        public async Task<IActionResult> DeleteCustomerByAdmin([FromRoute] DeleteCustomerByAdminCommand deleteCustomerByAdminCommand)
        {
            var result = await _mediator.Send(deleteCustomerByAdminCommand);
            return Ok(result);
        }

        // Customer Add Favorite Product
        [HttpPost("customer/add-favorite")]
        public async Task<IActionResult> AddFavoriteProduct([FromBody] AddFavoriteProductCommand addFavoriteCommand)
        {
            var response = await _mediator.Send(addFavoriteCommand);
            return Ok(response);
        }

        //Customer GetFavoriteListProducts

        [HttpGet("customer/getAllFavoriteProducts")]
        public async Task<IActionResult> GetAllFavoriteProducts()
        {
            var query = new GetAllFavoriteProductQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        //Customer Delete Favori Product
        [HttpDelete("customer/deleteFavoriteProduct/{favoriteId}")]
        public async Task<IActionResult> DeleteFavoriteProduct(int favoriteId)
        {
            var command = new DeleteFavoriteProductCommand { FavoriteId = favoriteId };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
