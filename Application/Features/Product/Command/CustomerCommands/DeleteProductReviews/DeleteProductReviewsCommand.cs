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

namespace Application.Features.Product.Command.CustomerCommands.DeleteProductReviews
{
    public class DeleteProductReviewsCommand : IRequest<DeleteProductReviewsCommandResponse>
    {
        public int ProductReviewId { get; set; }

        public class DeleteProductReviewsCommandHandler : IRequestHandler<DeleteProductReviewsCommand, DeleteProductReviewsCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IProductReviewRepository _productReviewRepository;

            public DeleteProductReviewsCommandHandler(IHttpContextAccessor httpContextAccessor, IProductReviewRepository productReviewRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _productReviewRepository = productReviewRepository;
            }

            public async Task<DeleteProductReviewsCommandResponse> Handle(DeleteProductReviewsCommand request, CancellationToken cancellationToken)
            {
                var customerId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value); 

                //Yorumu bul
                var productReview = await _productReviewRepository.GetAsync(pr => pr.Id == request.ProductReviewId);


                if (productReview == null) { throw new Exception("Yorum Bulunamadı"); }

                //Yorumun sahibi olup olmadığını kontrol ediyoruz.
                if (productReview.CustomerId != customerId)
                {
                    throw new AuthorizationException("Bu yorumu silmeye yetkiniz yok.");
                }

                //Yorum silinir
                await _productReviewRepository.DeleteAsync(productReview);


                return new DeleteProductReviewsCommandResponse
                {
                    Message = "Yorum başarıyla silindi. "
                };    
                
            }
        }
    }
}
