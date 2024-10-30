using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.CheckIfProductInBasket
{
    public class CheckIfPorductInBasketQuery : IRequest<CheckIfProductInBasketQueryResponse>
    {
        public int ProductId { get; set; }

        public class CheckIfProductInBasketQueryHandler : IRequestHandler<CheckIfPorductInBasketQuery, CheckIfProductInBasketQueryResponse>
        {
            private readonly ICustomerRepository _customerRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IShoppingBasketRepository _shoppingBasketRepository;

            public CheckIfProductInBasketQueryHandler(ICustomerRepository customerRepository, IHttpContextAccessor httpContextAccessor, IShoppingBasketRepository shoppingBasketRepository)
            {
                _customerRepository = customerRepository;
                _httpContextAccessor = httpContextAccessor;
                _shoppingBasketRepository = shoppingBasketRepository;
            }

            public async Task<CheckIfProductInBasketQueryResponse> Handle(CheckIfPorductInBasketQuery request, CancellationToken cancellationToken)
            {
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!int.TryParse(userIdString, out var userId))
                {
                    throw new Exception("Kullanıcı Bulunamadı");
                }

                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null) { throw new Exception("User Bulunamadı"); }

                var customerId = customer.Id;

                var productInBasket = await _shoppingBasketRepository.GetBasketItemAsync(customerId, request.ProductId);
                var isInBasket = productInBasket != null;

                return new CheckIfProductInBasketQueryResponse
                {
                    Success = true,
                    Message = isInBasket ? "Ürün Sepette Bulunuyor" : "Ürün Sepette Bulunmuyor",
                    IsInBasket = isInBasket
                };
            }
        }
    }
}
