using Application.Features.OrderDetails.DTOS;
using Application.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Queries.GetByIdOrderDetail
{
    public class GetByIdOrderDetailQuery : IRequest<GetByIdOrderDetailQueryResponse>
    {
        public int Id { get; set; }

        public GetByIdOrderDetailQuery(int id)
        {
            Id = id;
        }
        public class GetByIdOrderDetailQueryHandler : IRequestHandler<GetByIdOrderDetailQuery, GetByIdOrderDetailQueryResponse>
        {
            private readonly IOrderDetailRepository _orderDetailRepository;
            private readonly IMapper _mapper;

            public GetByIdOrderDetailQueryHandler(IOrderDetailRepository orderDetailRepository, IMapper mapper)
            {
                _orderDetailRepository = orderDetailRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdOrderDetailQueryResponse> Handle(GetByIdOrderDetailQuery request, CancellationToken cancellationToken)
            {
                var orderDetail = await _orderDetailRepository.GetByIdAsync(request.Id);
                if (orderDetail == null) {
                    throw new Exception("Sipariş Detayı Bulunamadı");
                }

                var orderDetailDto = _mapper.Map<OrderDetailDto>(orderDetail);  
                var response = new GetByIdOrderDetailQueryResponse(orderDetailDto);
                return response;
            }
        }
    }
}
