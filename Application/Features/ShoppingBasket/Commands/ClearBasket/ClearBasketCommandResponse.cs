using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.Commands.ClearBasket
{
    public class ClearBasketCommandResponse
    {
        public bool Success { get; set; }
        public string  Message { get; set; }
    }
}
