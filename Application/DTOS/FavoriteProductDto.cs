using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class FavoriteProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } // Ürün adı
        public string ProductImage { get; set; } // Ürün Resmi
        public string ProductDescription { get; set; } // Ürün açıklaması
        public decimal ProductPrice { get; set; } // Ürün fiyatı
    }
}
