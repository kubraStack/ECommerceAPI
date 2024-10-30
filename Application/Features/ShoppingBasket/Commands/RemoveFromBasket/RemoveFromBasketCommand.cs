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

namespace Application.Features.ShoppingBasket.Commands.RemoveFromBasket
{
    public class RemoveFromBasketCommand : IRequest<RemoveFromBasketCommandResponse>
    {
        public int ProductId { get; set; }

        public class RemoveFromBasketCommandHandler : IRequestHandler<RemoveFromBasketCommand, RemoveFromBasketCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IShoppingBasketRepository _shoppingBasketRepository;
            private readonly ICustomerRepository _customerRepository;

            public RemoveFromBasketCommandHandler(IHttpContextAccessor httpContextAccessor, IShoppingBasketRepository shoppingBasketRepository, ICustomerRepository customerRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _shoppingBasketRepository = shoppingBasketRepository;
                _customerRepository = customerRepository;
            }

            public async Task<RemoveFromBasketCommandResponse> Handle(RemoveFromBasketCommand request, CancellationToken cancellationToken)
            {
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!int.TryParse(userIdString, out var userId))
                {
                    throw new Exception("Geçersiz Kullanıcı ID");
                }

                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null)
                {
                    throw new Exception("Müşteri Bulunamadı");
                }

                var result = await _shoppingBasketRepository.RemoveFromBasketAsync(customer.Id, request.ProductId);
                return new RemoveFromBasketCommandResponse
                {
                    Success = result,
                    Message = result ? "Ürün Sepetten Çıkarıldı." : "Ürün Sepetten Çıkarılamadı."
                };

            }

        }
    }
}
