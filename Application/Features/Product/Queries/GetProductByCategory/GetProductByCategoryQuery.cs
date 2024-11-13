using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetProductByCategory
{
    public class GetProductByCategoryQuery : IRequest<List<GetProductByCategoryQueryResponse>>
    {
        public string Category { get; set; }

        public GetProductByCategoryQuery(string category)
        {
            Category = category;
        }

        public class GetProductByCategoryQueryHandler : IRequestHandler<GetProductByCategoryQuery, List<GetProductByCategoryQueryResponse>>
        {
            private readonly IProductRepository _productRepository;

            public GetProductByCategoryQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<List<GetProductByCategoryQueryResponse>> Handle(GetProductByCategoryQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetProductsByCategoryAsync(request.Category);

                var response = products.Select(p => new GetProductByCategoryQueryResponse
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    Price = p.Price,
                    StockQuantity = p.StockQuantity,
                    Description = p.Description,
                    Category = p.Category?.Name ?? "Unknow"
                }).ToList();
                return response;
            }
        }
    }
}
