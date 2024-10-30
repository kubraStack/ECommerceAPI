using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Commands.AddToBasket
{
    public  class AddToBasketCommand : IRequest<AddToBasketCommandResponse>
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public class AddToBasketCommandHandler : IRequestHandler<AddToBasketCommand, AddToBasketCommandResponse>
        {
            private readonly IShoppingBasketRepository _shoppingBasketRepository;
            private readonly ICustomerRepository _customerRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public AddToBasketCommandHandler(IShoppingBasketRepository shoppingBasketRepository, IHttpContextAccessor httpContextAccessor, ICustomerRepository customerRepository = null)
            {
                _shoppingBasketRepository = shoppingBasketRepository;
                _httpContextAccessor = httpContextAccessor;
                _customerRepository = customerRepository;
            }

            public async Task<AddToBasketCommandResponse> Handle(AddToBasketCommand request, CancellationToken cancellationToken)
            {
                // Giriş yapmış kullanıcıdan UserId'yi al
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                // UserId geçerli bir int değilse hata döndür
                if (!int.TryParse(userIdString, out var userId))
                {
                    return new AddToBasketCommandResponse
                    {
                        Success = false,
                        Message = "Geçersiz kullanıcı ID."
                    };
                }

                // Customer tablosunda bu UserId'ye sahip bir müşteri var mı kontrol et
                var customer = await _customerRepository.GetByUserIdAsync(userId); // GetByUserIdAsync metodunu tanımlamanız gerekmektedir.

                if (customer == null)
                {
                    return new AddToBasketCommandResponse
                    {
                        Success = false,
                        Message = "Müşteri bulunamadı."
                    };
                }
                // Sepete ekleme işlemini gerçekleştirin
                var result = await _shoppingBasketRepository.AddToBasketAsync(customer.Id, request.ProductId, request.Quantity);

                return new AddToBasketCommandResponse
                {
                    Success = result,
                    Message = result ? "Ürün sepete eklendi." : "Ürün sepete eklenemedi."
                };
            }
        }

    }
}
