using Application.Features.Order.DTOS;
using Application.Features.Product.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.QueryByAdmin.GetById
{
    public class GetByIdCustomerQueryResponse
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public IEnumerable<OrderDto>  Orders { get; set; }
      

    }
}
