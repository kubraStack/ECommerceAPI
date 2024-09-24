using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
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
    public class UpdateCustomerCommand : IRequest<UpdateCustomerCommandResponse>
    {
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }

     

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
               
                var customerToUpdate = await _customerRepository.GetAsync(c => c.UserId == currentUserId);
                await _customerRepository.UpdateAsync(customerToUpdate);
                return new UpdateCustomerCommandResponse { Id = currentUserId , BillingAddress = customerToUpdate.BillingAddress, ShippingAddress = customerToUpdate.ShippingAddress};
            }
        }
    }
}
