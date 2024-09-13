using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.AddProductCommand
{
    public class AddProductByAdminCommand : IRequest<AddProductByAdminCommandResponse>, ISequredRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; } 
        public int CategoryId { get; set; }
        public string[] ReuqiredRoles => ["Admin"];

        public class AddProductCommandHandler : IRequestHandler<AddProductByAdminCommand, AddProductByAdminCommandResponse>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _contextAccessor;

            public AddProductCommandHandler(IProductRepository productRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
            {
                _productRepository = productRepository;
                _mapper = mapper;
                _contextAccessor = contextAccessor;
            }

            public async Task<AddProductByAdminCommandResponse> Handle(AddProductByAdminCommand request, CancellationToken cancellationToken)
            {
                var isAdmin = _contextAccessor.HttpContext.User.IsInRole("Admin");
                if (!isAdmin)
                {
                    throw new AuthorizationException("Ürün eklemeye yetkiniz yok !");
                }

                var product = _mapper.Map<Domain.Entities.Product>(request);

                await _productRepository.AddAsync(product);

                return new AddProductByAdminCommandResponse
                {
                    ProductId = product.Id,
                    Success = true,
                    Message = "Product added successfuly"
                };
            }
        }
    }
}
