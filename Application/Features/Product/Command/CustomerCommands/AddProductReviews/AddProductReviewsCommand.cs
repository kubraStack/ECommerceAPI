using Application.Repositories;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.CustomerCommands.AddProductReviews
{
    public class AddProductReviewsCommand : IRequest<AddProductReviewsCommandResponse>
    {
        public int ProductId { get; set; }
      
        public string Review { get; set; }
        public int Rating { get; set; }

        public class AddProductReviewsCommandHandler : IRequestHandler<AddProductReviewsCommand, AddProductReviewsCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IProductReviewRepository _productReviewsRepository;
            

            public AddProductReviewsCommandHandler(IHttpContextAccessor httpContextAccessor, IProductReviewRepository productReviewsRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _productReviewsRepository = productReviewsRepository;
            }

            public async Task<AddProductReviewsCommandResponse> Handle(AddProductReviewsCommand request, CancellationToken cancellationToken)
            {
                var customerId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var productReview = new ProductReview
                {
                    CustomerId = customerId,
                    Review = request.Review,
                    ProductId = request.ProductId,
                    Rating = request.Rating,
                    ReviewDate = DateTime.Now,
                };

                //Yorum veritabanına ekle
                await _productReviewsRepository.AddAsync(productReview);

                return new AddProductReviewsCommandResponse
                {
                    Message = "Yorum Başarıyla Eklendi"
                };
            }
        }
    }
}
