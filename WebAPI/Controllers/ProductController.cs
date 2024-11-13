using Application.Features.Product.Command.AdminCommands.AddProductCommand;
using Application.Features.Product.Command.AdminCommands.ChangeProductPriceCommand;
using Application.Features.Product.Command.AdminCommands.DeleteProductCommand;
using Application.Features.Product.Command.AdminCommands.ReStockProductCommand;
using Application.Features.Product.Command.AdminCommands.UpdateProductCommand;
using Application.Features.Product.Command.CustomerCommands.AddProductReviews;
using Application.Features.Product.Command.CustomerCommands.DeleteProductReviews;
using Application.Features.Product.Command.CustomerCommands.UpdateProductReviews;
using Application.Features.Product.Queries.GetById;
using Application.Features.Product.Queries.GetFilteredProduct;
using Application.Features.Product.Queries.GetListProduct;
using Application.Features.Product.Queries.GetProductDetails;
using Application.Features.Product.Queries.GetTopSellingProduct;
using MediatR;
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
        [HttpGet("products/{id}")]
        public async Task<IActionResult> GetProductByIdAdmin(int id)
        {
           var query = new GetProductByIdQuery { Id = id };
           var response = await _mediator.Send(query);
            
           

            return Ok(response);
        }

        //Admin Get all product
        [HttpGet("products")]
        public async Task<IActionResult> GetListProducts()
        {
            var query = new GetListProductQuery();
            var result = await _mediator.Send(query);
            return Ok(result.Products);
        }

        //Admin Delete product
        [HttpDelete("product/{id}")]
        
        public async Task<IActionResult> DeleteProductByAdmin(int id) 
        { 
            var command = new DeleteProductByAdminCommand { ProductId = id };
            await _mediator.Send(command);

           return Ok(command);
        }
        //Admin get productDetail
        [HttpGet("product/details")]
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

        //Customer Add-Comment
        [HttpPost("customer/product/reviews/{productId}")]
        public async Task<IActionResult> AddProductReviews(int productId, [FromBody] AddProductReviewsCommand reviewCommand)
        {
            reviewCommand.ProductId = productId;
            var response = await _mediator.Send(reviewCommand);
            return Ok(response);
        }

        //Customer Delete-Comment
        [HttpDelete("customer/product/reviews/{id}")]
        public async Task<IActionResult> DeleteProductReview(int id)
        {
           var result = await _mediator.Send(new DeleteProductReviewsCommand { ProductReviewId = id });
            return Ok(result);
        }

        //Customer Update-Comment
        [HttpPut("customer/product/reviews/{productReviewId}")]
        public async Task<IActionResult> UpdateProductReview (int productReviewId, [FromBody] UpdateProductReviewsCommand updateProductReviewsCommand) 
        { 
            updateProductReviewsCommand.ProductReviewId = productReviewId;
            var response = await _mediator.Send(updateProductReviewsCommand);
            return Ok(response);
        }

        //Top Selling Products
        [HttpGet("top-selling")]
        public async Task<IActionResult> GetTopSellingProducts([FromQuery] int count)
        {
            var query = new GetTopSellingProductQuery { TopCount = count };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        //Filtered Products
        [HttpGet("filtered-products")]
        public async Task<IActionResult> GetFilteredProducts([FromQuery] GetFilteredProductQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
