using Application.Features.ShoppingBasket.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Queries.GetShoppingBasket
{
    public class GetShoppingBasketQueryResponse
    {
        public ShoppingBasketDto ShoppingBasket { get; set; }
    }
}
