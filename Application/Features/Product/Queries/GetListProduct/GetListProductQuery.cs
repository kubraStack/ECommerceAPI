using Application.Repositories;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetListProduct
{
    public class GetListProductQuery : IRequest<GetListProductQueryResponse>
    {
        public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, GetListProductQueryResponse>
        {
            private readonly IProductRepository _productRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetListProductQueryHandler(IProductRepository productRepository, IHttpContextAccessor httpContextAccessor)
            {
                _productRepository = productRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetListProductQueryResponse> Handle(GetListProductQuery request, CancellationToken cancellationToken)
            {
                var allProducts = await _productRepository.GetListAsync(
                    include: query => query.Include(p=>p.Category)
                );

                return new GetListProductQueryResponse
                {
                    Products = allProducts
                };
            }
        }
    }
}
