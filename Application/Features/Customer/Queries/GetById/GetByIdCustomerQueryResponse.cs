using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetById
{
    public class GetByIdCustomerQueryResponse
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public string UserName { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        


    }
}
