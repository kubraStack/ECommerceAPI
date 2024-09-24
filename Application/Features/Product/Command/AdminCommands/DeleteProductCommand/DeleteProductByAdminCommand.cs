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

namespace Application.Features.Product.Command.AdminCommands.DeleteProductCommand
{
    public class DeleteProductByAdminCommand : IRequest<DeleteProductByAdminCommandResponse>, ISequredRequest
    {
        public int ProductId { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class DeleteProductByAdminCommandHandler : IRequestHandler<DeleteProductByAdminCommand, DeleteProductByAdminCommandResponse>
        {
           
            private readonly IProductRepository _productRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public DeleteProductByAdminCommandHandler(IProductRepository productRepository, IHttpContextAccessor httpContextAccessor)
            {
                _productRepository = productRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<DeleteProductByAdminCommandResponse> Handle(DeleteProductByAdminCommand request, CancellationToken cancellationToken)
            {
                var isAdmin = _httpContextAccessor.HttpContext.User.IsInRole("Admin");

                if (!isAdmin) {

                    throw new BusinessException("Bu işlemi yapmak için yetkiniz yok !");
                }

                //Silinecek ürünü bul
                var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product == null) 
                {
                    throw new Exception("Ürün bulunamadı !");
                }

                //Ürünü sil 
                await _productRepository.DeleteAsync(product);
                return new DeleteProductByAdminCommandResponse
                {
                    ProductId = request.ProductId,
                    Success = true,
                    Message = "Ürün Başarıyla Silindi"
                };

                    
            }
        }
    }
}
