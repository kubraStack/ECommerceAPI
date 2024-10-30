using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetBasketItemQuantity
{
    public class GetBasketItemQuantityQuery : IRequest<GetBasketItemQuantityQueryResponse>
    {
        public int ProductId { get; set; }

        public class GetBasketItemQuantityQueryHandler : IRequestHandler<GetBasketItemQuantityQuery, GetBasketItemQuantityQueryResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICustomerRepository _customerRepository;
            private readonly IShoppingBasketRepository _shoppingBasketRepository;

            public GetBasketItemQuantityQueryHandler(IHttpContextAccessor httpContextAccessor, ICustomerRepository customerRepository, IShoppingBasketRepository shoppingBasketRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _customerRepository = customerRepository;
                _shoppingBasketRepository = shoppingBasketRepository;
            }

            public async Task<GetBasketItemQuantityQueryResponse> Handle(GetBasketItemQuantityQuery request, CancellationToken cancellationToken)
            {
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!int.TryParse(userIdString, out var userId))
                {
                    throw new Exception("Kullanıcı Bulunamadı");
                }
                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null) { throw new Exception("User Bulunamadı"); }

                var customerId = customer.Id;

                var basketItem = await _shoppingBasketRepository.GetBasketItemAsync(customerId, request.ProductId);
                if (basketItem == null)
                {
                    return new GetBasketItemQuantityQueryResponse
                    {
                        Success = false,
                        Message = "Bu ürün sepette bulunamadı",
                        Quantity = 0
                    };
                }

                return new GetBasketItemQuantityQueryResponse
                {
                    Success = true,
                    Message = "Ürün miktarı başarıyla alındı",
                    Quantity = basketItem.Quantity
                };
            }
        }
    }
}
