using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetById
{
    public class GetByIdCustomerQuery : IRequest<GetByIdCustomerQueryResponse>
    {
        public int Id { get; set; }

        public class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQuery, GetByIdCustomerQueryResponse>
        {
            private readonly IMapper _mapper;
            private ICustomerRepository _customerRepository;

            public GetByIdCustomerQueryHandler(IMapper mapper, ICustomerRepository customerRepository)
            {
                _mapper = mapper;
                _customerRepository = customerRepository;
            }

            public async Task<GetByIdCustomerQueryResponse> Handle(GetByIdCustomerQuery request, CancellationToken cancellationToken)
            {
                Domain.Entities.Customer? customer = await _customerRepository.GetAsync(c => c.Id == request.Id);

                if (customer is null)
                {
                    throw new BusinessException("Böyle bir veri bulunamadı");
                }

                GetByIdCustomerQueryResponse response = _mapper.Map<GetByIdCustomerQueryResponse>(customer);
                return response;
            }
        }
    }
}
