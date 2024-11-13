using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetTopSellingProduct
{
    public class GetTopSellingProductQuery : IRequest<List<GetTopSellingProductQueryResponse>>
    {
        public int TopCount { get; set; } = 10; //Varsayılan olarak en çok satılan 10 ürünü getirecek

        public class GetTopSellingProductQueryHandler : IRequestHandler<GetTopSellingProductQuery, List<GetTopSellingProductQueryResponse>>
        {
            private readonly IProductRepository _productRepository;

            public GetTopSellingProductQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<List<GetTopSellingProductQueryResponse>> Handle(GetTopSellingProductQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetTopSellingProductQueryAsync(request.TopCount);
                return products;
            }
        }
    }
}
