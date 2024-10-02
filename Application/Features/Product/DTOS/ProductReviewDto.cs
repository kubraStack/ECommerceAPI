using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.DTOS
{
    public class ProductReviewDto
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
    }
}
