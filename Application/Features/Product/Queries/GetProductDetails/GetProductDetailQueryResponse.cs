using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetProductDetails
{
    public class GetProductDetailQueryResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; } //Ürün görüntüsünü saklamak için
        public int CategoryId { get; set; }
    }
}
