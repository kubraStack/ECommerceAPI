﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShoppingBasket.DTO
{
    public class ShoppingBasketDetailDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; } 
        public string ProductName { get; set; } 
        public int Quantity { get; set; } 
        public decimal Price { get; set; } 
    }

}
