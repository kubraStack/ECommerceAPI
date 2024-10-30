using Application.Features.ShoppingBasket.Commands.ClearBasket;
using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Commands.UpdateBasketItemQuantity
{
    public  class UpdateBasketItemQuantityCommand : IRequest<UpdateBaskerItemQuantityCommandResponse>
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public class UpdateBasketItemQuantityCommandHandler : IRequestHandler<UpdateBasketItemQuantityCommand, UpdateBaskerItemQuantityCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IShoppingBasketRepository _shoppingBasketRepository;
            private readonly ICustomerRepository _customerRepository;

            public UpdateBasketItemQuantityCommandHandler(IHttpContextAccessor httpContextAccessor, IShoppingBasketRepository shoppingBasketRepository, ICustomerRepository customerRepository = null)
            {
                _httpContextAccessor = httpContextAccessor;
                _shoppingBasketRepository = shoppingBasketRepository;
                _customerRepository = customerRepository;
            }

            public async Task<UpdateBaskerItemQuantityCommandResponse> Handle(UpdateBasketItemQuantityCommand request, CancellationToken cancellationToken)
            {
                var userIdString = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                // Kullanıcı ID'sini alırken bir hata varsa
                if (string.IsNullOrEmpty(userIdString) || !int.TryParse(userIdString, out var userId))
                {
                    throw new Exception("Geçersiz kullanıcı Id");
                }
                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null) { throw new Exception("User Bulunamadı"); }

                var customerId = customer.Id;

                var result = await _shoppingBasketRepository.UpdateBasketItemQuantityAsync(customerId, request.ProductId, request.Quantity);
                return new UpdateBaskerItemQuantityCommandResponse
                {
                    Success = result,
                    Message = result ? "Sepetteki Öğrenin Miktarı Başarıyla Güncellendi" : "Sepetteki öğesinin miktarı güncellenemedi. "
                };
            }
        }
    }
}
