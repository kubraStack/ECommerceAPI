using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.AddProductCommand
{
    public class AddProductCommand : IRequest<AddProductCommandResponse>, ISequredRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; } 
        public int CategoryId { get; set; }
        public string[] ReuqiredRoles => ["Admin"];

        public class AddProductCommandHandler : IRequestHandler<AddProductCommand, AddProductCommandResponse>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public AddProductCommandHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<AddProductCommandResponse> Handle(AddProductCommand request, CancellationToken cancellationToken)
            {
                var product = _mapper.Map<Domain.Entities.Product>(request);

                await _productRepository.AddAsync(product);

                return new AddProductCommandResponse
                {
                    ProductId = product.Id,
                    Success = true,
                    Message = "Product added successfuly"
                };
            }
        }
    }
}
