using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.DeleteByAdmin
{
    public class DeleteCustomerByAdminCommand : IRequest<DeleteCustomerByAdminCommandResponse>, ISequredRequest
    {
        public int Id { get; set; }
        public string[] ReuqiredRoles => ["Admin"];

        public class  DeleteCustomerByAdminCommandHandler : IRequestHandler<DeleteCustomerByAdminCommand, DeleteCustomerByAdminCommandResponse>
        {
            private readonly ICustomerRepository _customerRepository;
            private readonly IUserRepository _userRepository;

            public DeleteCustomerByAdminCommandHandler(ICustomerRepository customerRepository, IUserRepository userRepository)
            {
                _customerRepository = customerRepository;
                _userRepository = userRepository;
            }

            public async Task<DeleteCustomerByAdminCommandResponse> Handle(DeleteCustomerByAdminCommand request, CancellationToken cancellationToken)
            {
                var customerToDelete = await _customerRepository.GetAsync(c => c.Id == request.Id);
                var userToDelete = await _userRepository.GetAsync(u => u.Id == request.Id);

                await _customerRepository.SoftDeleteAsync(customerToDelete);
                await _userRepository.SoftDeleteAsync(userToDelete);

                return new();

            }
        }
    }
}
