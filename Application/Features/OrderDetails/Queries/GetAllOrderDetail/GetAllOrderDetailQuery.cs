using Application.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Queries.GetAllOrderDetail
{
    public class GetAllOrderDetailQuery : IRequest<List<GetAllOrderDetailQueryResponse>>
    {

        public class GetAllOrderDetailQueryHandler : IRequestHandler<GetAllOrderDetailQuery, List<GetAllOrderDetailQueryResponse>>
        {
            private readonly IOrderDetailRepository _orderDetailRepository;
            private readonly IMapper _mapper;

            public GetAllOrderDetailQueryHandler(IOrderDetailRepository orderDetailRepository, IMapper mapper)
            {
                _orderDetailRepository = orderDetailRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllOrderDetailQueryResponse>> Handle(GetAllOrderDetailQuery request, CancellationToken cancellationToken)
            {
                var orderDetails = await _orderDetailRepository.GetListAsync();
                var response = _mapper.Map<List<GetAllOrderDetailQueryResponse>>(orderDetails); 

                return response;
            }
        }
    }
}
