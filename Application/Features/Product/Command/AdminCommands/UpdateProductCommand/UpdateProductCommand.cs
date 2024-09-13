using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.UpdateProductCommand
{
    public class UpdateProductCommand : IRequest<UpdateProductCommandResponse>, ISequredRequest
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; } //Ürün görüntüsünü saklamak için
        public int CategoryId { get; set; }
        public string[] ReuqiredRoles => ["Admin"];

        public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdateProductCommandResponse>
        {
            private readonly IHttpContextAccessor _contextAccessor;
            private readonly IProductRepository _productRepository;

            public UpdateProductCommandHandler(IHttpContextAccessor contextAccessor, IProductRepository productRepository)
            {
                _contextAccessor = contextAccessor;
                _productRepository = productRepository;
            }

            public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
            {
                var user = _contextAccessor.HttpContext.User;
                if (!user.IsInRole("Admin"))
                {
                    throw new AuthorizationException("Bu işlemi yapmaya yetkiniz yok !");    
                }

                //Find product
                var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product == null) 
                {
                    throw new Exception("Ürün bulunamadı !");
                }

                //Update Product
                product.Name = request.Name;
                product.Description = request.Description;
                product.Price = request.Price;
                product.StockQuantity = request.StockQuantity;
                product.ImageUrl = request.ImageUrl;
                product.CategoryId = request.CategoryId;

                await _productRepository.UpdateAsync(product);

                return new UpdateProductCommandResponse
                {
                   Name = request.Name,
                   Description = request.Description,
                   Price = request.Price,
                   StockQuantity = request.StockQuantity,
                   ImageUrl = request.ImageUrl,
                   CategoryId = request.CategoryId,
                };
            }
        }
    }
}
