using Application.Features.Customer.DTOS;
using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetAllFavoriteProduct
{
    public class GetAllFavoriteProductQuery : IRequest<GetAllFavoriteProductsQueryResponse>
    {
        public class GetAllFavoriteProductQueryHandler : IRequestHandler<GetAllFavoriteProductQuery, GetAllFavoriteProductsQueryResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IProductRepository _productRepository;
            private readonly IFavoriteRepository _favoriteRepository;

            public GetAllFavoriteProductQueryHandler(IFavoriteRepository favoriteRepository, IHttpContextAccessor httpContextAccessor, IProductRepository productRepository)
            {
                _favoriteRepository = favoriteRepository;
                _httpContextAccessor = httpContextAccessor;
                _productRepository = productRepository;
            }

            public async Task<GetAllFavoriteProductsQueryResponse> Handle(GetAllFavoriteProductQuery request, CancellationToken cancellationToken)
            {
                var customerId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                if (customerId == null)
                {
                    throw new Exception("Müşteri bulunamadı.");
                }
              
                var favoriteProducts = await _favoriteRepository.GetListAsync(f => f.CustomerId == customerId);

                var favoriteProductDtos = new List<FavoriteProductDto>();
                foreach (var favorite in favoriteProducts)
                {
                    var product = await _productRepository.GetByIdAsync(favorite.ProductId); // Ürün bilgilerini al

                    if (product != null)
                    {
                        favoriteProductDtos.Add(new FavoriteProductDto
                        {
                            ProductId = product.Id,
                            ProductName = product.Name,
                            ProductImage = product.ImageUrl,
                            ProductDescription = product.Description,
                            ProductPrice = product.Price
                        });
                    }
                }

                return new GetAllFavoriteProductsQueryResponse(favoriteProductDtos);
            }
        }
    }
}
