using Application.Features.Product.Command.AdminCommands.AddProductCommand;
using Application.Features.Product.Command.AdminCommands.ChangeProductPriceCommand;
using Application.Features.Product.Command.AdminCommands.DeleteProductCommand;
using Application.Features.Product.Command.AdminCommands.ReStockProductCommand;
using Application.Features.Product.Command.AdminCommands.UpdateProductCommand;

using Application.Features.Product.Queries.GetById;
using Application.Features.Product.Queries.GetListProduct;
using Application.Features.Product.Queries.GetProductDetails;
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

        // Admin Add Product
        [HttpPost("admin/addProducts")]
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
            var query = new GetListProductByAdminQuery();
            var result = await _mediator.Send(query);
            return Ok(result.Products);
        }

        //Admin Delete product
        [HttpDelete("admin/product/{id}")]
        
        public async Task<IActionResult> DeleteProductByAdmin(int id) 
        { 
            var command = new DeleteProductByAdminCommand { ProductId = id };
            await _mediator.Send(command);

           return Ok(command);
        }
        //Admin get productDetail
        [HttpGet("admin/product/details")]
        public async Task<IActionResult> GetProductDetails(int Id)
        {
            var query = new GetProductDetailQuery { Id = Id };
            var response = await _mediator.Send(query); 
            return Ok(response);
        }


        //Admin Update Product-Stock
        [HttpPut("admin/product/restock")]
        public async Task<IActionResult> ReStockProduct([FromBody] ReStockProductCommand reStockCommand)
        {
            var response = await _mediator.Send(reStockCommand);
            return Ok(response);

        }
        //Admin Update Product-Price
        [HttpPut("admin/product/change-price")]
        public async Task<IActionResult> ChangeProductPrice([FromBody] ChangePriceCommand changePriceCommand)
        {
            var response = await _mediator.Send(changePriceCommand);
            return Ok(response);
        }

        //Admin Update product
        [HttpPut("admin/product/update")]
        public async Task<IActionResult> UpdateProductByAdmin( [FromBody] UpdateProductCommand command)
        {
            
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
