using Application.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Commands.CreatePayment
{
    public class CreatePaymentCommand : IRequest<CreatePaymentCommandResponse>
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }


        public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, CreatePaymentCommandResponse>
        {
            private IPaymentRepository _paymentRepository;
            private IPaymentMethodRepository _paymentMethodRepository;

            public CreatePaymentCommandHandler(IPaymentRepository paymentRepository, IPaymentMethodRepository paymentMethodRepository)
            {
                _paymentRepository = paymentRepository;
                _paymentMethodRepository = paymentMethodRepository;
            }

            public async Task<CreatePaymentCommandResponse> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
            {
                var paymentMethod = await _paymentMethodRepository.GetByIdAsync(request.PaymentMethodId);
                if (paymentMethod == null) {

                    throw new Exception("Geçersiz ödeme yöntemi !");
                }

                var payment = new Domain.Entities.Payment
                {
                    OrderId = request.OrderId,
                    Amount = request.Amount,
                    PaymentMethodId = request.PaymentMethodId,
                    PaymentDate = DateTime.UtcNow,
                    
                };

                await _paymentRepository.AddAsync(payment);

                var response = new CreatePaymentCommandResponse
                {
                    PaymentId = payment.Id,
                    OrderId = payment.OrderId,
                    Amount = payment.Amount,
                    PaymentDate = payment.PaymentDate,
                    PaymentMethodId = payment.PaymentMethodId,
                    PaymentMethodName = payment.PaymentMethod.Name,
                    PaymentStatus = request.PaymentStatus
                };
                return response;
            }
        }
    }
}
