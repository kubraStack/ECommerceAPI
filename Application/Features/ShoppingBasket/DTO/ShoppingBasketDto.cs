using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.DTO
{
    public class ShoppingBasketDto
    {
        public int Id { get; set; }
        public List<ShoppingBasketDetailDto> Items { get; set; } 
    }
}
