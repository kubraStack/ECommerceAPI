
using Application.Features.ShoppingBasket.Commands.AddToBasket;
using Application.Features.ShoppingBasket.Commands.ClearBasket;
using Application.Features.ShoppingBasket.Commands.RemoveFromBasket;
using Application.Features.ShoppingBasket.Commands.UpdateBasketItemQuantity;
using Application.Features.ShoppingBasket.Queries.CheckIfProductInBasket;
using Application.Features.ShoppingBasket.Queries.GetBasketItemQuantity;
using Application.Features.ShoppingBasket.Queries.GetBasketTotalAmount;
using Application.Features.ShoppingBasket.Queries.GetShoppingBasket;
using Application.Features.ShoppingBasket.Queries.GetShoppingBasketDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ShoppingBasketController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShoppingBasketController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddToBasket")]
        public async Task<IActionResult> AddToCart([FromBody] AddToBasketCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("Update-Quantity")]
        public async Task<IActionResult> UpdateBasketItemQuantity([FromBody] UpdateBasketItemQuantityCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("Clear")]
        public async Task<IActionResult> ClearBasket([FromBody] ClearBasketCommand command)
        {
            
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> RemoveFromBasket([FromBody] RemoveFromBasketCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("GetBasket")]
        public async Task<IActionResult> GetBasket()
        {
            var query = new GetShoppingBasketQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("GetBasketDetail")]
        public async Task<IActionResult> GetBasketDetail()
        {
            var query = new GetShoppingBasketDetailQuery();
            var result = await _mediator.Send(query);   
            return Ok(result);
        }

        [HttpGet("GetBasketTotalAmount")]
        public async Task<IActionResult> GetBasketTotalAmount()
        {
            var query = new GetBasketTotalAmountQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("BasketItemQuantity")]
        public async Task<IActionResult> GetBasketItemQuantity([FromQuery] int productId)
        {
            var query = new GetBasketItemQuantityQuery
            {
                ProductId = productId
            };
            var result = await _mediator.Send(query);     
            return Ok(result);
        }

        [HttpGet("CheckIfProductInBasket")]
        public async Task<IActionResult> CheckIfProductInBasket([FromQuery] int productId)
        {
            var query = new CheckIfPorductInBasketQuery
            {
                ProductId = productId
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
