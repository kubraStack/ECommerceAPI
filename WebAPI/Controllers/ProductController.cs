using Application.Features.Product.Command.AdminCommands.AddProductCommand;
using Application.Features.Product.Command.AdminCommands.DeleteProductCommand;
using Application.Features.Product.Queries.AdminQueries.GetById;
using Application.Features.Product.Queries.AdminQueries.GetListProduct;
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
        public async Task<IActionResult> AddProductByAdmin(AddProductByAdminCommand productCommand)
        {
      
            var response = await _mediator.Send(productCommand);

            return Ok(response);
        }

        //Admin Get productbyid
        [HttpGet("admin/products/{id}")]
        public async Task<IActionResult> GetProductByIdAdmin(int id)
        {
           var query = new GetProductByIdAdminQuery { Id = id };
           var response = await _mediator.Send(query);
            
           

            return Ok(response);
        }

        //Admin Get all product
        [HttpGet("admin/products")]
        public async Task<IActionResult> GetListProductByAdmin()
        {
            var query = new GetListProductByadminQuery();
            var result = await _mediator.Send(query);
            return Ok(result.Products);
        }

        //Admin Delete product
        [HttpDelete("admin/product/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProductByAdmin(int id) 
        { 
            var command = new DeleteProductByAdminCommand { ProductId = id };
            await _mediator.Send(command);

           return Ok(command);
        }
       

    }
}
