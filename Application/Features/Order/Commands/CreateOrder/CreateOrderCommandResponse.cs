using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommandResponse
    {
        public int OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
    }
}
