using Application.Features.Payment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Queries.GetPaymentsByOrderId
{
    public class GetPaymentByOrderIdQueryResponse
    {
        public IEnumerable<PaymentDto> Payments { get; set; }
    }
}
