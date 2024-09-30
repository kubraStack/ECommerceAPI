using Application.Repositories;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.CustomerCommands.UpdateProductReviews
{
    public class UpdateProductReviewsCommand : IRequest<UpdateProductReviewsCommandResponse>
    {
        public int ProductReviewId { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }

        public class UpdateProductReviewsCommandHandler : IRequestHandler<UpdateProductReviewsCommand, UpdateProductReviewsCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IProductReviewRepository _productReviewRepository;

            public UpdateProductReviewsCommandHandler(IHttpContextAccessor httpContextAccessor, IProductReviewRepository productReviewRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _productReviewRepository = productReviewRepository;
            }

            public async Task<UpdateProductReviewsCommandResponse> Handle(UpdateProductReviewsCommand request, CancellationToken cancellationToken)
            {
                var customerId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var productReview = await _productReviewRepository.GetAsync(pr => pr.Id == request.ProductReviewId);
                if (productReview == null) { throw new Exception("Yorum Bulunamadı"); }

                if (productReview.CustomerId != customerId)
                {
                    throw new AuthorizationException("Bu yorumu güncellemeye yetkiniz yok");
                }

                //yorum güncelle
                productReview.Review = request.Review;
                productReview.Rating = request.Rating;

                await _productReviewRepository.UpdateAsync(productReview);
                return new UpdateProductReviewsCommandResponse { 
                    
                   Message =  "Yorum başarıyla güncellendi"
                
                };
            }
        }
    }
}
