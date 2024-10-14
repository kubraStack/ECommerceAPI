using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Commands.CreateOrderDetail
{
    public class CreateOrderDetailCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int OrderDetailId { get; set; }
    }
}
