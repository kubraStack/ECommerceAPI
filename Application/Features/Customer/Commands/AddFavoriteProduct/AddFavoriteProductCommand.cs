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

namespace Application.Features.Customer.Commands.AddFavoriteProduct
{
    public class AddFavoriteProductCommand : IRequest<AddFavoriteProductCommandResponse>
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public class AddFavoriteProductCommandHandler : IRequestHandler<AddFavoriteProductCommand, AddFavoriteProductCommandResponse>
        {
            private readonly IProductRepository _productRepository;
            private readonly ICustomerRepository _customerRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IFavoriteRepository _favoriteRepository;

            public AddFavoriteProductCommandHandler(IProductRepository productRepository, ICustomerRepository customerRepository, IHttpContextAccessor httpContextAccessor, IFavoriteRepository favoriteRepository)
            {
                _productRepository = productRepository;
                _customerRepository = customerRepository;
                _httpContextAccessor = httpContextAccessor;
                _favoriteRepository = favoriteRepository;
            }

            public async Task<AddFavoriteProductCommandResponse> Handle(AddFavoriteProductCommand request, CancellationToken cancellationToken)
            {
                var customerId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                if (customerId == null)
                {
                    throw new Exception("Müşteri bulunamadı.");
                }

                //Ürünün varlığını kontrol et.
                var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product == null)
                {
                    return new AddFavoriteProductCommandResponse(false, "Product not found");
                }

                //Daha önce favorilere eklendiğini kontrol et.
                var existingFavorite = await _favoriteRepository.GetAsync( f => f.CustomerId == customerId && f.ProductId == request.ProductId);
                if (existingFavorite != null)
                {
                    return new AddFavoriteProductCommandResponse(false, "Product is already in favorites",product.Id, product.Name);
                }

                //Favoriyi ekle
                var favorite = new Favorite
                {
                    CustomerId = customerId,
                    ProductId = product.Id,
                };
                await _favoriteRepository.AddAsync(favorite);

                return new AddFavoriteProductCommandResponse(true,"Product added to favorites successfully", product.Id, product.Name);
            }

        }
    }
}
