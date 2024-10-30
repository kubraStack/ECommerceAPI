using Application.Features.ShoppingBasket.DTO;
using Application.Repositories;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetShoppingBasket
{
    public class GetShoppingBasketQuery : IRequest<GetShoppingBasketQueryResponse>
    {
        public class GetShoppingBasketQueryHandler : IRequestHandler<GetShoppingBasketQuery, GetShoppingBasketQueryResponse>
        {
            private readonly IShoppingBasketRepository _shoppingBasketRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICustomerRepository _customerRepository;
            public GetShoppingBasketQueryHandler(IShoppingBasketRepository shoppingBasketRepository, IHttpContextAccessor httpContextAccessor = null, ICustomerRepository customerRepository = null)
            {
                _shoppingBasketRepository = shoppingBasketRepository;
                _httpContextAccessor = httpContextAccessor;
                _customerRepository = customerRepository;
            }

            public async Task<GetShoppingBasketQueryResponse> Handle(GetShoppingBasketQuery request, CancellationToken cancellationToken)
            {
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!int.TryParse(userIdString, out var userId))
                {
                    throw new Exception("Kullanıcı Bulunamadı");
                }
                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null) { throw new Exception("User Bulunamadı"); }

                var customerId = customer.Id;

                var basket = await _shoppingBasketRepository.GetBasketAsync(customerId);
                if (basket == null) {
                    basket = new Domain.Entities.ShoppingBasket
                    {
                        CustomerId = customerId,
                        ShoppingBasketDetails = new List<ShoppingBasketDetail>()
                    };

                    await _shoppingBasketRepository.AddAsync(basket);
                }

                var shoppingBasketDto = new ShoppingBasketDto
                {
                    Id = basket.Id,
                    Items = basket.ShoppingBasketDetails.Select(d => new ShoppingBasketDetailDto
                    {
                        Id = d.Id,
                        ProductId = d.ProductId,
                        Quantity = d.Quantity,
                    }).ToList()
                };

                return new GetShoppingBasketQueryResponse
                {
                    ShoppingBasket = shoppingBasketDto
                };
            }
        }
    }
}
