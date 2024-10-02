using Application.Features.Order.DTOS;
using Application.Features.OrderDetails.DTOS;
using Application.Features.Product.DTOS;
using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.QueryByAdmin.GetById
{
    public class GetByIdCustomerQuery : IRequest<GetByIdCustomerQueryResponse>, ISequredRequest
    {
        public int Id { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQuery, GetByIdCustomerQueryResponse>
        {
            private readonly ICustomerRepository _customerRepository;
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;

            public GetByIdCustomerQueryHandler(ICustomerRepository customerRepository, IUserRepository userRepository, IMapper mapper)
            {
                _customerRepository = customerRepository;
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdCustomerQueryResponse> Handle(GetByIdCustomerQuery request, CancellationToken cancellationToken)
            {
                // Kullanıcıyı al
                var user =  await _userRepository.GetByIdAsync(request.Id);
                if (user == null)
                {
                    // Kullanıcı bulunamazsa uygun bir hata mesajı döndürmek gerekebilir
                    throw new Exception("User not found");
                }

                // Müşteri verilerini al
                var customer = await _customerRepository.GetAsync(c => c.UserId == request.Id, include: c => c
                    
                    .Include(u => u.Orders)
                );
               
                if (customer == null)
                {
                    // Müşteri bulunamazsa uygun bir hata mesajı döndürmek gerekebilir
                    throw new Exception("Customer not found");
                }
                
                // Yanıtı oluştur
                var response = new GetByIdCustomerQueryResponse
                {
                    FullName = $"{user.FirstName} {user.LastName}",
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    ShippingAddress = customer.ShippingAddress,
                    BillingAddress = customer.BillingAddress,
                    Orders = customer.Orders.Select(o => new OrderDto
                    {
                        OrderId = o.Id,
                        TotalAmount = o.TotalAmount
                    }).ToList(),
                  
                };

                return response;
            }
        }
    }
}
