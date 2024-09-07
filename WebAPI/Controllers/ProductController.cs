using Application.Features.Product.Command.AdminCommands.AddProductCommand;
using Application.Features.Product.Queries.AdminQueries.GetById;
using Core.Entitites;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST: api/Product
        [HttpPost("admin/products")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddProductByAdmin(AddProductCommand productCommand)
        {
      
            var response = await _mediator.Send(productCommand);

            return Ok(response);
        }

        //Get
        [HttpGet("admin/products/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
           var query = new GetProductByIdQuery { Id = id };
           var response = await _mediator.Send(query);
            
           

            return Ok(response);
        }

       

    }
}
