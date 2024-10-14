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

namespace Application.Features.Category.Commands.RemoveCategoryFromProductCommand
{
    public class RemoveCategoryFromProductCommand : IRequest<RemoveCategoryFromProductCommandResponse>, ISequredRequest
    {
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string[] RequiredRoles => ["Admin"];


        public class RemoveCategoryFromProductCommandHandler : IRequestHandler<RemoveCategoryFromProductCommand, RemoveCategoryFromProductCommandResponse>
        {
            private const int UnassignedCategoryId = -1;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IProductRepository _productRepository;

            public RemoveCategoryFromProductCommandHandler(IHttpContextAccessor httpContextAccessor, IProductRepository productRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _productRepository = productRepository;
            }

            public async Task<RemoveCategoryFromProductCommandResponse> Handle(RemoveCategoryFromProductCommand request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

                if (userRole != "Admin")
                {
                    throw new UnauthorizedAccessException("Bu işlemi yapmaya yetkiniz yok.");
                }

                var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product == null)
                {
                    throw new KeyNotFoundException("Ürün bulunamadı.");
                }

                if (product.CategoryId != request.CategoryId)
                {
                    throw new InvalidOperationException("Ürün bu kategoriye ait değil.");
                }

                product.CategoryId = UnassignedCategoryId;
                await _productRepository.UpdateAsync(product);

                return new RemoveCategoryFromProductCommandResponse
                {
                    Success = true,
                    Message = "Kategori ürünün kategorisinden başarıyla kaldırıldı."
                };
            }
        }
    }
}
