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
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public GetTopSellingProductQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        public class GetTopSellingProductQueryHandler : IRequestHandler<GetTopSellingProductQuery, List<GetTopSellingProductQueryResponse>>
        {
            private readonly IProductRepository _productRepository;

            public GetTopSellingProductQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<List<GetTopSellingProductQueryResponse>> Handle(GetTopSellingProductQuery request, CancellationToken cancellationToken)
            {
                var result = await _productRepository.GetTopSellingProductQueryAsync(request.PageNumber, request.PageSize);
                return result;
            }
        }
    }
}
