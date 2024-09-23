using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Utilities.Encryption;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.QueryByAdmin.GetAll
{
    public class GetAllCustomerQuery : IRequest<GetAllCustomerQueryResponse> , ISequredRequest
    {
        public int Page  { get; set; }
        public int PageSize { get; set; }

        public string[] ReuqiredRoles => ["Admin"];

        public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, GetAllCustomerQueryResponse>
        {
            private readonly ICustomerRepository _customerRepository;
            private readonly IMapper _mapper;
            
            public GetAllCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
            {
                _customerRepository = customerRepository;
                _mapper = mapper;
               
            }

            public async Task<GetAllCustomerQueryResponse> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
            {
                var query = _customerRepository.GetList(include: q => q.Include(c => c.User))
                                                .Where(c=> c.User.UserType == Core.Entitites.UserType.Customer);

                var totalCount = query.Count();
                if (request.PageSize == 0)
                {
                    request.PageSize = totalCount;
                }

                var customers = query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(c => new
                {
                    c.Id,
                    c.User.FirstName,
                    c.User.LastName,                        
                    c.User.Email,
                    c.User.PhoneNumber,
                    c.Orders,
                    c.ShippingAddress,
                    c.BillingAddress,
                    c.ShoppingCart,
                    c.ProductReviews
                }).ToList();

                return new GetAllCustomerQueryResponse
                {
                    Customers = customers,
                    TotalCount = totalCount
                };
            }
        }
    }
}
