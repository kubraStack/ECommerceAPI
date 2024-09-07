using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetAll
{
    public class GetAllCustomerQueryResponse
    {
        public int TotalCount { get; set; }
        public object Customers { get; set; }
    }
}
