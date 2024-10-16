﻿using Application.Features.Order.Commands.CancelOrder;
using Application.Features.Order.Commands.CreateOrder;
using Application.Features.Order.Commands.ProductReturn;
using Application.Features.Order.Queries.GetAllOrders;
using Application.Features.Order.Queries.GetByIdOrder;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("order/create-order")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand createOrderCommand)
        {
            var result = await _mediator.Send(createOrderCommand);
            return Ok(result);
        }

        [HttpGet("order/all-orders")]
        public async Task<IActionResult> GetAllOrders()
        {
            var query = new GetAllOrdersQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }


        [HttpDelete("order/delete/{id}")]
        public async Task<IActionResult> CancelledOrder(int id)
        {
            var command = new CancelOrderCommand { OrderId = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("order/return")]
        public async Task<IActionResult> ReturnProduct([FromBody] ProductReturnCommand returnProductCommand)
        {
            var result = await _mediator.Send(returnProductCommand);
            return Ok(result);
        }

        [HttpGet("orders/{id}")]
        public async Task<IActionResult> GetOrderById(int id) { 
            
            var query = new GetOrderByIdQuery { OrderId = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        
        }
    }
}
