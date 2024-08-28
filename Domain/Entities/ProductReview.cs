using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductReview : Entity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; } // 1-5 arası bir puanlama sistemi
        public DateTime ReviewDate { get; set; }
    }
}
