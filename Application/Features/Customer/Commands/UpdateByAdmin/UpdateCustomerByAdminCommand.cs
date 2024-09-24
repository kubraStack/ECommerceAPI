using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.UpdateByAdmin
{
    public class UpdateCustomerByAdminCommand : IRequest<UpdateCustomerByAdminCommanResponse>, ISequredRequest
    {
        public int Id { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class UpdateCustomerByAdminCommandHandler : IRequestHandler<UpdateCustomerByAdminCommand, UpdateCustomerByAdminCommanResponse>
        {
            private readonly ICustomerRepository _customerRepository;

            public UpdateCustomerByAdminCommandHandler(ICustomerRepository customerRepository)
            {
                _customerRepository = customerRepository;
            }

            public async Task<UpdateCustomerByAdminCommanResponse> Handle(UpdateCustomerByAdminCommand request, CancellationToken cancellationToken)
            {
                var customerToUpdate = await _customerRepository.GetAsync(c => c.Id == request.Id);
                customerToUpdate.BillingAddress = request.BillingAddress != null ? request.BillingAddress : customerToUpdate.BillingAddress;
                customerToUpdate.ShippingAddress = request.ShippingAddress != null ? request.ShippingAddress : customerToUpdate.ShippingAddress;
                await _customerRepository.UpdateAsync(customerToUpdate);
                return new() { Id = request.Id, BillingAddress = request.BillingAddress, ShippingAddress = request.ShippingAddress };

                throw new NotImplementedException();
            }
        }
    }
}
