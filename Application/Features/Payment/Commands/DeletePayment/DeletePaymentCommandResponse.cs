using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Commands.DeletePayment
{
    public class DeletePaymentCommandResponse
    {
        public int PaymentId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
