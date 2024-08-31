using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : Entity
    {
        public string ShippingAddress { get; set; }
        public string BillingAddress  { get; set; }
        public User User { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection <ProductReview> ProductReviews { get; set; }
    }
}
