using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetBasketTotalAmount
{
    public class GetBasketTotalAmountQuery : IRequest<GetBasketTotalAmountQueryResponse>
    {
        public class GetBasketTotalAmountQueryHandler : IRequestHandler<GetBasketTotalAmountQuery, GetBasketTotalAmountQueryResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICustomerRepository _customerRepository;
            private readonly IShoppingBasketRepository _shoppingBasketRepository;

            public GetBasketTotalAmountQueryHandler(IHttpContextAccessor httpContextAccessor, ICustomerRepository customerRepository, IShoppingBasketRepository shoppingBasketRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _customerRepository = customerRepository;
                _shoppingBasketRepository = shoppingBasketRepository;
            }

            public async Task<GetBasketTotalAmountQueryResponse> Handle(GetBasketTotalAmountQuery request, CancellationToken cancellationToken)
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
                if (shoppingBasket == null || !shoppingBasket.ShoppingBasketDetails.Any())
                {
                    return new GetBasketTotalAmountQueryResponse
                    {
                        Success = false,
                        Message = "Sepet boş veya bulunamadı"
                    };
                }

                //Toplam tutar
                var totalAmount = shoppingBasket.ShoppingBasketDetails.Sum(item =>(decimal)item.Price * item.Quantity);
                return new GetBasketTotalAmountQueryResponse
                {
                    Success = true,
                    Message = "Toplam tutar başarıyla hesaplandı",
                    TotalAmount = totalAmount
                };
            }
        }
    }
}
