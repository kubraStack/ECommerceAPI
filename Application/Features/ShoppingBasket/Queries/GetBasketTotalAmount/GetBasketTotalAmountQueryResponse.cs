using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetBasketTotalAmount
{
    public class GetBasketTotalAmountQueryResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public decimal TotalAmount { get; set; }

     
        public GetBasketTotalAmountQueryResponse()
        {
            
        }
    }
}
