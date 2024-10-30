using Application.Features.ShoppingBasket.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetShoppingBasketDetails
{
    public class GetShoppingBasketDetailQueryResponse
    {
        public int BasketId { get; set; }
        public int CustomerId { get; set; }
        public List<ShoppingBasketDetailDto> BasketDetails { get; set; }


        public GetShoppingBasketDetailQueryResponse()
        {
            
        }

    }
}
