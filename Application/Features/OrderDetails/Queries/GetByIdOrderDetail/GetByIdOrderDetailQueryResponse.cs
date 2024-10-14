using Application.Features.OrderDetails.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Queries.GetByIdOrderDetail
{
    public class GetByIdOrderDetailQueryResponse
    {
        public OrderDetailDto OrderDetail { get; set; }

        public GetByIdOrderDetailQueryResponse(OrderDetailDto orderDetail)
        {
            OrderDetail = orderDetail;
        }
    }
}
