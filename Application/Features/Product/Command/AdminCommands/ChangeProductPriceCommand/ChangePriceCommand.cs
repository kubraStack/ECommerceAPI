using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.ChangeProductPriceCommand
{
    public class ChangePriceCommand : IRequest<ChangePriceCommandResponse>, ISequredRequest
    {
        public int ProductId { get; set; }
        public decimal NewPrice { get; set; }
        public decimal? Discount { get; set; } //İsteğe bağlı indirim
        public decimal? TaxRate { get; set; } //İsteğe bağlı KDV oranı
        public string[] RequiredRoles =>["Admin"];

        public class ChangePriceCommandHandler : IRequestHandler<ChangePriceCommand, ChangePriceCommandResponse>
        {
            private readonly IProductRepository _productRepository;

            public ChangePriceCommandHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<ChangePriceCommandResponse> Handle(ChangePriceCommand request, CancellationToken cancellationToken)
            {
               var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product == null)
                {
                    return new ChangePriceCommandResponse("Product is not found");
                }

                var oldPrice = product.Price;

                product.Price = request.NewPrice;

                //İndirim ve KDV
                decimal finalPrice = product.Price; //Güncellenmiş fiyat

                if (request.Discount.HasValue)
                {
                    finalPrice -= (finalPrice * (request.Discount.Value / 100));
                }

                if (request.TaxRate.HasValue)
                {
                    finalPrice += (finalPrice * (request.TaxRate.Value / 100));
                }
                //Final price'ı ürün nesnesine ata
                product.FinalPrice = finalPrice;

                //Fiyatı Güncelle
                await _productRepository.UpdateAsync(product);

                return new ChangePriceCommandResponse
                (
                    request.ProductId,
                    oldPrice,
                    request.NewPrice,
                    product.FinalPrice.Value,
                    "Product price updated successfullly"

                );
            }
        }
    }
}
