using Application.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.CreateCustomerRole
{
    public class CustomerRoleCommand : IRequest<CustomerRoleCommanResponse>
    {
        public int UserId { get; set; }

        public class CustomerRoleCommandHandler : IRequestHandler<CustomerRoleCommand, CustomerRoleCommanResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IUserOperationClaimRepository _userOperationClaimRepository;

            public CustomerRoleCommandHandler(IUserRepository userRepository, IMapper mapper, IUserOperationClaimRepository userOperationClaimRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _userOperationClaimRepository = userOperationClaimRepository;
            }

            public async Task<CustomerRoleCommanResponse> Handle(CustomerRoleCommand request, CancellationToken cancellationToken)
            {
               //Kullanıcıyı al

                var currentlyUser = await _userRepository.GetAsync(u => u.Id == request.UserId);

                if (currentlyUser == null)
                {
                    //Kullanıcı bulunamadı
                    throw new Exception("Kullanıcı Bulunamadı !");
                }

                //Kullanıcı rolü => customer olarak güncellendi
                currentlyUser.UserType = Core.Entitites.UserType.Customer;
                await _userRepository.UpdateAsync(currentlyUser);

                //Kullanıcıya müşteri rolü atandı
                await _userOperationClaimRepository.AddAsync(new Domain.Entities.UserOperationClaim
                {
                    UserId = request.UserId,
                    OperationClaimId = 2
                });

                return new CustomerRoleCommanResponse();
               
            }
        }

    }
}
