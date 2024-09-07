using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.Update
{
    public class UpdateCustomerCommand : IRequest<UpdateCustomerCommandResponse>, ISequredRequest
    {
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public string[] ReuqiredRoles => ["Customer"];

        public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, UpdateCustomerCommandResponse>
        {
            private ICustomerRepository _customerRepository;
            private IHttpContextAccessor _httpContextAccessor;

            public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IHttpContextAccessor httpContextAccessor)
            {
                _customerRepository = customerRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
            {
                var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var customerToUpdate = await _customerRepository.GetAsync(c => c.Id == currentUserId);
                customerToUpdate.BillingAddress = request.BillingAddress != null ? request.BillingAddress : customerToUpdate.BillingAddress;
                customerToUpdate.ShippingAddress = request.ShippingAddress != null ? request.ShippingAddress : customerToUpdate.ShippingAddress;

                await _customerRepository.UpdateAsync(customerToUpdate);
                return new() { CustomerId = currentUserId, ShippingAddress = customerToUpdate.ShippingAddress, BillingAddress = customerToUpdate.BillingAddress };
            }
        }
    }
}
