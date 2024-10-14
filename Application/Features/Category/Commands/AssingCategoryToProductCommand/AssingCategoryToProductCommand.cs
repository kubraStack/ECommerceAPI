using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Commands.AssingCategoryToProductCommand
{
    public class AssingCategoryToProductCommand : IRequest<AssignCategoryToProductCommandResponse>, ISequredRequest
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public AssingCategoryToProductCommand(int productId, int categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        public class AssingCategoryToProductCommandHandler : IRequestHandler<AssingCategoryToProductCommand, AssignCategoryToProductCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IProductRepository _productRepository;
            private readonly ICategoryRepository _categoryRepository;

            public AssingCategoryToProductCommandHandler(IHttpContextAccessor httpContextAccessor, IProductRepository productRepository, ICategoryRepository categoryRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _productRepository = productRepository;
                _categoryRepository = categoryRepository;
            }

            public async Task<AssignCategoryToProductCommandResponse> Handle(AssingCategoryToProductCommand request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

                if (userRole != "Admin")
                {
                    throw new Exception("Bu işlemi yapmaya yetkiniz yok.");
                }

                var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product == null) {
                    throw new Exception("Ürün Bulunamadı.");
                }

                var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
                if (category == null)
                {
                    throw new Exception("Kategori Bulunamadı.");
                }

                product.CategoryId = request.CategoryId;
                await _productRepository.UpdateAsync(product);

                return new AssignCategoryToProductCommandResponse
                {
                    Success = true,
                    Message = "Kategori başarıyla ürünle ilişkilendirildi."
                };
            }
        }
    }
}
