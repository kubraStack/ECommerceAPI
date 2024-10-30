using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Commands.UpdatePayment
{
    public class UpdatePaymentStatusCommand : IRequest<UpdatePaymentStatusCommandResponse>
    {
        public int PaymentId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public class UpdatePaymentStatusCommandHandler : IRequestHandler<UpdatePaymentStatusCommand, UpdatePaymentStatusCommandResponse>
        {
            public Task<UpdatePaymentStatusCommandResponse> Handle(UpdatePaymentStatusCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
