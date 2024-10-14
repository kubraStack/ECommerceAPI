using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderStatus.Queries.GetByIdOrderStatus
{
    public class GetByIdOrderStatusQueryResponse
    {
        public int OrderStatusId { get; set; }
        public string OrderName { get; set; }
        public string Description { get; set; }
    }
}
