using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetFilteredProduct
{
    public class GetFilteredProductQueryResponse
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public bool? InStock { get; set; }
    }
}
