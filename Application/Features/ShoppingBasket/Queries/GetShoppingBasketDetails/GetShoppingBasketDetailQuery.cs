using Application.Features.ShoppingBasket.DTO;
using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetShoppingBasketDetails
{
    public class GetShoppingBasketDetailQuery : IRequest<GetShoppingBasketDetailQueryResponse>
    {
        public class GetShoppingBasketDetailQueryHandler : IRequestHandler<GetShoppingBasketDetailQuery, GetShoppingBasketDetailQueryResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICustomerRepository _customerRepository;
            private readonly IShoppingBasketRepository _shoppingBasketRepository;

            public GetShoppingBasketDetailQueryHandler(IHttpContextAccessor httpContextAccessor, ICustomerRepository customerRepository, IShoppingBasketRepository shoppingBasketRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _customerRepository = customerRepository;
                _shoppingBasketRepository = shoppingBasketRepository;
            }

            public async Task<GetShoppingBasketDetailQueryResponse> Handle(GetShoppingBasketDetailQuery request, CancellationToken cancellationToken)
            {
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!int.TryParse(userIdString, out var userId))
                {
                    throw new Exception("Kullanıcı Bulunamadı");
                }
                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null) { throw new Exception("User Bulunamadı"); }

                var customerId = customer.Id;

                var shoppingBasket = await _shoppingBasketRepository.GetBasketWithDetailAsync(customerId);
                if (shoppingBasket == null)
                {
                    throw new Exception("Bu müşteri için sepet bulunamadı");
                }

                var response = new GetShoppingBasketDetailQueryResponse
                {
                    BasketId = shoppingBasket.Id,
                    CustomerId = customerId,
                    BasketDetails = shoppingBasket.ShoppingBasketDetails.Select(detail => new ShoppingBasketDetailDto
                    {
                        ProductId = detail.ProductId,
                        ProductName = detail.Product.Name,
                        Price = detail.Product.Price,
                        Quantity = detail.Quantity
                    }).ToList()

                };
                return response;
            }
        }
    }
}
