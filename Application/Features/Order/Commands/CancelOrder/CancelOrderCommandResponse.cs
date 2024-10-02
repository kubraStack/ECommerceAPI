using Application.Features.Order.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Commands.CancelOrder
{
    public class CancelOrderCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public OrderDto  CancelledOrder { get; set; } //İptal edilen sipariş bilgileri
    }
}
