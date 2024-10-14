using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderStatus.Commands.CreateOrderStatusCommand
{
    public class CreateOrderStatusCommandResponse
    {
        public int OrderStatusId { get; set; }
        public string Message { get; set; }
    }
}
