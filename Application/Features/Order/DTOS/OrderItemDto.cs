using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.DTOS
{
    public class OrderItemDto
    {
        public int ProductId { get; set; } //Ürün id
        public int Quantity { get; set; } //Ürün miktarı
       
    }
}
