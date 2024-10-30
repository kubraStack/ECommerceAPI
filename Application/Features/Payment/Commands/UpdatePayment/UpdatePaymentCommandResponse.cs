using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Commands.UpdatePayment
{
    public class UpdatePaymentCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
