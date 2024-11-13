using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetTopSellingProduct
{
    public class GetTopSellingProductQueryResponse
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TotalSold { get; set; } // Toplam satılan tutar
        public string ImageUrl { get; set; }
    }
}
