using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.DTOS
{
    public class OrderDetailDto
    {
        public int ProductId { get; set; } // Ürün ID
        public string ProductName { get; set; } // Ürün adı
        public int Quantity { get; set; } // Miktar
        public decimal UnitPrice { get; set; } // Birim fiyat
    }
}
