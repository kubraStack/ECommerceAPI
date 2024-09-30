using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetProductDetails
{
    public class GetProductDetailQuery : IRequest<GetProductDetailQueryResponse>
    {
        public int Id { get; set; }


        public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailQuery, GetProductDetailQueryResponse>
        {
            private readonly IProductRepository _productRepository;

            public GetProductDetailsQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<GetProductDetailQueryResponse> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetAsync(p => p.Id == request.Id);

                if (product == null)
                {

                    throw new Exception("Ürün Bulunamadı");

                }

                return new GetProductDetailQueryResponse
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    FinalPrice = product.FinalPrice,
                    StockQuantity = product.StockQuantity,
                    ImageUrl = product.ImageUrl,
                    CategoryId = product.CategoryId,
                };
            }
        }
    }
}
