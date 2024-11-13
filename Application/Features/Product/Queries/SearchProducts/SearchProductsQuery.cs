using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.SearchProducts
{
    public class SearchProductsQuery : IRequest<List<SearchProductQueryResponse>>
    {
        public string SearchTerm { get; set; }

        public SearchProductsQuery(string searchTerm)
        {
            SearchTerm = searchTerm;
        }

        public class SearchProductsQueryHandler : IRequestHandler<SearchProductsQuery, List<SearchProductQueryResponse>>
        {
            private readonly IProductRepository _productRepository;

            public SearchProductsQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<List<SearchProductQueryResponse>> Handle(SearchProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.SearchProductsAsync(request.SearchTerm);

                var response = products.Select(p => new SearchProductQueryResponse
                {
                    ProductId= p.Id,
                    ProductName= p.Name,
                    Description= p.Description,
                    ImageUrl= p.ImageUrl,
                    Price= p.Price,
                    StockQuantity= p.StockQuantity,
                    Category = p.Category?.Name ?? "Unknow"
                }).ToList();
                return response;
            }
        }
    }
}
