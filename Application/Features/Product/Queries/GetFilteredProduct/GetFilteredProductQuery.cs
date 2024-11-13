using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetFilteredProduct
{
    public class GetFilteredProductQuery : IRequest<List<GetFilteredProductQueryResponse>>
    {
        public string Category { get; set; }  // Buraya kategori filtresi ekliyoruz
        public decimal? MinPrice { get; set; }  // Min fiyat filtresi
        public decimal? MaxPrice { get; set; }  // Max fiyat filtresi
        public bool? InStock { get; set; }

        public class GetFilteredProductQueryHandler : IRequestHandler<GetFilteredProductQuery, List<GetFilteredProductQueryResponse>>
        {
            private readonly IProductRepository _productRepository;

            public GetFilteredProductQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<List<GetFilteredProductQueryResponse>> Handle(GetFilteredProductQuery request, CancellationToken cancellationToken)
            {
                 // Kategori boş ve fiyat aralığı belirtilmişse, hata mesajı alsın
                if (string.IsNullOrEmpty(request.Category) && (request.MinPrice.HasValue || request.MaxPrice.HasValue))
                {
                    throw new Exception("Category must be selected when filtering by price.");
                }
                var filteredProducts = await _productRepository.GetFilteredProductsAsync(request);
                return filteredProducts;
            }
        }
    }
}
