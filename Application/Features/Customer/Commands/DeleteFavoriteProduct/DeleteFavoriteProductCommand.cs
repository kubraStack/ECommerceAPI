using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.DeleteFavoriteProduct
{
    public class DeleteFavoriteProductCommand : IRequest<DeleteFavoriteProductCommandResponse>
    {
        public int FavoriteId { get; set; }

        public class DeleteFavoriteProductCommandHandler : IRequestHandler<DeleteFavoriteProductCommand, DeleteFavoriteProductCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IFavoriteRepository _favoriteRepository;

            public DeleteFavoriteProductCommandHandler(IHttpContextAccessor httpContextAccessor, IFavoriteRepository favoriteRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _favoriteRepository = favoriteRepository;
            }

            public async Task<DeleteFavoriteProductCommandResponse> Handle(DeleteFavoriteProductCommand request, CancellationToken cancellationToken)
            {
                var customerId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                //favori kaydını al
                var favorite = await _favoriteRepository.GetByIdAsync(request.FavoriteId);

                if (favorite == null) {

                    throw new Exception("Favori ürün bulunamadı");
                }

                await _favoriteRepository.DeleteAsync(favorite);
                return new DeleteFavoriteProductCommandResponse
                {
                    Success = true,
                    Message = "Favori Ürün Silindi"
                };


            }
        }
    }
}
