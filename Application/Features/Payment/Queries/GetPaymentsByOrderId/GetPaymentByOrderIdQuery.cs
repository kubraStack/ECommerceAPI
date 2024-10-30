using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Payment.Queries.GetPaymentsByOrderId
{
    public class GetPaymentByOrderIdQuery : IRequest<GetPaymentByOrderIdQueryResponse>
    {
        public int OrderId { get; set; }

        public GetPaymentByOrderIdQuery(int orderId)
        {
            OrderId = orderId;
        }

        public class GetPaymentByOrderIdQueryHandler : IRequestHandler<GetPaymentByOrderIdQuery, GetPaymentByOrderIdQueryResponse>
        {
            private readonly IPaymentRepository _paymentRepository;

            public GetPaymentByOrderIdQueryHandler(IPaymentRepository paymentRepository)
            {
                _paymentRepository = paymentRepository;
            }

            public async Task<GetPaymentByOrderIdQueryResponse> Handle(GetPaymentByOrderIdQuery request, CancellationToken cancellationToken)
            {
                var payments = await _paymentRepository.GetPaymentByOrderIdAsync(request.OrderId);
                return new GetPaymentByOrderIdQueryResponse
                {
                    Payments = payments
                };
            }
        }
    }
}
