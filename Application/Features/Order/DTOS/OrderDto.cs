using Application.Features.OrderDetails.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.DTOS
{
    public class OrderDto
    {
        public int OrderId { get; set; } // Sipariş ID
        public DateTime OrderDate { get; set; } // Sipariş tarihi
        public decimal TotalAmount { get; set; } // Toplam tutar
        public ICollection<OrderDetailDto> OrderDetails { get; set; } // Sipariş detayları
    }
}
