using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.Update
{
    public class UpdateCustomerCommandResponse
    {
        public int CustomerId { get; set; }
      
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
    }
}
