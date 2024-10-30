using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Commands.DeletePayment
{
    public class DeletePaymentCommand : IRequest<DeletePaymentCommandResponse>, ISequredRequest
    {
        public int PaymentId { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, DeletePaymentCommandResponse>
        {
            private readonly IPaymentRepository _paymentRepository;

            public DeletePaymentCommandHandler(IPaymentRepository paymentRepository)
            {
                _paymentRepository = paymentRepository;
            }

            public async Task<DeletePaymentCommandResponse> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
            {
                var payment = await _paymentRepository.GetByIdAsync(request.PaymentId);
                if (payment == null)
                {
                    throw new Exception("Payment not found");
                }

                await _paymentRepository.DeleteAsync(payment);

                return new DeletePaymentCommandResponse
                {
                    PaymentId = request.PaymentId,
                    Success = true,
                    Message = "Payment is deleted"
                };
            }
        }
    }
}
