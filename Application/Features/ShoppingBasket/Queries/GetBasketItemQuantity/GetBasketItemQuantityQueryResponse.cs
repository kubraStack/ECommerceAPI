using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetBasketItemQuantity
{
    public class GetBasketItemQuantityQueryResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int Quantity { get; set; }
        public GetBasketItemQuantityQueryResponse()
        {
            
        }
    }
}
