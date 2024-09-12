using Application.Repositories;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.AdminQueries.GetListProduct
{
    public class GetListProductByAdminQuery : IRequest<GetListProductByAdminResponse>
    {
        public class GetListProductQueryHandler : IRequestHandler<GetListProductByAdminQuery, GetListProductByAdminResponse>
        {
            private readonly IProductRepository _productRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetListProductQueryHandler(IProductRepository productRepository, IHttpContextAccessor httpContextAccessor)
            {
                _productRepository = productRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetListProductByAdminResponse> Handle(GetListProductByAdminQuery request, CancellationToken cancellationToken)
            {
                var isAdmin = _httpContextAccessor.HttpContext.User.IsInRole("Admin");
                if (!isAdmin)
                {
                    throw new AuthorizationException("Bu işlem için yetkiniz yok!");
                }

                var allProducts = await _productRepository.GetListAsync();

                return new GetListProductByAdminResponse
                {
                    Products = allProducts
                };
            }
        }
    }
}
