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

namespace Application.Features.ShoppingBasket.Commands.ClearBasket
{
    public  class ClearBasketCommand : IRequest<ClearBasketCommandResponse>
    {
        public class ClearBasketCommandHandler : IRequestHandler<ClearBasketCommand, ClearBasketCommandResponse>
        {
            private readonly IShoppingBasketRepository _shoppingBasketRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICustomerRepository _customerRepository;


            public ClearBasketCommandHandler(IShoppingBasketRepository shoppingBasketRepository, IHttpContextAccessor httpContextAccessor, ICustomerRepository customerRepository = null)
            {
                _shoppingBasketRepository = shoppingBasketRepository;
                _httpContextAccessor = httpContextAccessor;
                _customerRepository = customerRepository;
            }

            public async Task<ClearBasketCommandResponse> Handle(ClearBasketCommand request, CancellationToken cancellationToken)
            {
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                // Kullanıcı ID'sini alırken bir hata varsa
                if (string.IsNullOrEmpty(userIdString) || !int.TryParse(userIdString, out var userId))
                {
                    return new ClearBasketCommandResponse
                    {
                        Success = false,
                        Message = "Geçersiz Müşteri ID."
                    };
                }
                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null) { throw new Exception("User Bulunamadı"); }

                var customerId = customer.Id;

                // Sepeti al
                var shoppingBasket = await _shoppingBasketRepository.GetBasketAsync(customerId);
                if (shoppingBasket == null)
                {
                    return new ClearBasketCommandResponse
                    {
                        Success = false,
                        Message = "Bu müşteri için sepet bulunamadı."
                    };
                }

                // Sepeti temizle
                var result = await _shoppingBasketRepository.ClearBasketAsync(customerId);
                return new ClearBasketCommandResponse
                {
                    Success = result,
                    Message = result ? "Sepet Başarıyla Temizlendi" : "Sepet Temizlenemedi"
                };
            }
        }
    }
}
