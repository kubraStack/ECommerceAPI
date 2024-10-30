using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Commands.CreatePayment
{
    public class CreatePaymentCommandResponse
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

    }
}
