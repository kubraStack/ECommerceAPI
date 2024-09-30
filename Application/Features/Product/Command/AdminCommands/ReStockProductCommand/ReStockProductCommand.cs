using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.ReStockProductCommand
{
    public class ReStockProductCommand : IRequest<ReStockProductCommandResponse>, ISequredRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string OperationType { get; set; } //increase or decrease
        public string[] RequiredRoles => ["Admin"];

        public class ReStockProductCommandHandler : IRequestHandler<ReStockProductCommand, ReStockProductCommandResponse>
        {
            private readonly IProductRepository _productRepository;

            public ReStockProductCommandHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<ReStockProductCommandResponse> Handle(ReStockProductCommand request, CancellationToken cancellationToken)
            {
               //Ürünü bul
               var product = await _productRepository.GetByIdAsync(request.ProductId);

                if (product == null) {

                    throw new Exception("Product is not found");
                }

                //İşlem tipine göre stok güncellemesi
                if (request.OperationType == "increase")
                {
                    //Stock miktarını güncelle
                    product.StockQuantity += request.Quantity;
                }
                else if (request.OperationType == "decrease")
                {
                    //Stok azalmasını kontrol et
                    if (product.StockQuantity < request.Quantity)
                    {
                        return new ReStockProductCommandResponse(
                            "Insufficient stock to decrease"
                        );
                    }
                    product.StockQuantity -= request.Quantity;
                }


                //Ürünü veritabanında güncelle
                await _productRepository.UpdateAsync(product);

                var operation = request.OperationType == "increase" ? "increased" : "decreased";

                // Yanıtı oluştur ve döndür
                return new ReStockProductCommandResponse(

                  product.Id,
                  product.StockQuantity,
                  $"Stock {operation} successfully"

                );
            }
        }
    }
}
