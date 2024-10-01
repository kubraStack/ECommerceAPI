using Application.Features.Customer.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetAllFavoriteProduct
{
    public class GetAllFavoriteProductsQueryResponse
    {
        public List<FavoriteProductDto> FavoriteProducts { get; set; }

        public GetAllFavoriteProductsQueryResponse(List<FavoriteProductDto> favoriteProducts)
        {
            FavoriteProducts = favoriteProducts;
        }
    }
}
