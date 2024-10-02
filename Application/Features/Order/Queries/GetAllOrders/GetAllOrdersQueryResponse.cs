using Application.Features.Order.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Queries.GetAllOrders
{
    public class GetAllOrdersQueryResponse
    {
        public List<OrderDto> Orders {  get; set; }
    }
}
