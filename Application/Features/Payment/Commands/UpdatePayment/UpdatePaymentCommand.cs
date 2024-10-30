using Application.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Commands.UpdatePayment
{
    public class UpdatePaymentCommand : IRequest<UpdatePaymentCommandResponse>
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public int PaymentMethodId { get; set; } //Ödeme Yöntemi ID'si

        public class UpdatePaymentStatusCommandHandler : IRequestHandler<UpdatePaymentCommand, UpdatePaymentCommandResponse>
        {
            private readonly IPaymentRepository _paymentRepository;

            public UpdatePaymentStatusCommandHandler(IPaymentRepository paymentRepository)
            {
                _paymentRepository = paymentRepository;
            }

            public async Task<UpdatePaymentCommandResponse> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
            {
                var payment = await _paymentRepository.GetByIdAsync(request.PaymentId);
                if (payment == null) {
                    throw new Exception("Payment not found");
                }

                payment.Amount = request.Amount;    
                payment.PaymentMethodId = request.PaymentMethodId;
                payment.PaymentStatus = request.Status;
                
                await _paymentRepository.UpdateAsync(payment);

                return new UpdatePaymentCommandResponse
                {
                    Success = true,
                    Message = "Payment updated successfully"
                };
            }
        }
    }
}
