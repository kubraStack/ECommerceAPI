using Application.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.AdminQueries.GetById
{
    public class GetProductByIdAdminQuery : IRequest<GetProductByIdAdminResponse>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdAdminQuery, GetProductByIdAdminResponse>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<GetProductByIdAdminResponse> Handle(GetProductByIdAdminQuery request, CancellationToken cancellationToken)
            {
               var product = await _productRepository.GetByIdAsync(request.Id);
                if (product == null) {
                    throw new Exception("Ürün Bulunamadı");
                }

                return _mapper.Map<GetProductByIdAdminResponse>(product);
            }
        }
    }
}
