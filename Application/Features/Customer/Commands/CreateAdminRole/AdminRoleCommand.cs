using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.CreateCustomerRole
{
    public class AdminRoleCommand : IRequest<AdminRoleCommandResponse>
    {
        public int UserId { get; set; }

        public class CustomerRoleCommandHandler : IRequestHandler<AdminRoleCommand, AdminRoleCommandResponse>
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

            public async Task<AdminRoleCommandResponse> Handle(AdminRoleCommand request, CancellationToken cancellationToken)
            {
                // Kullanıcıyı al
                var currentlyUser = await _userRepository.GetAsync(u => u.Id == request.UserId);

                if (currentlyUser == null)
                {
                    // Kullanıcı bulunamadı
                    throw new BusinessException("Kullanıcı Bulunamadı !");
                }

                // Kullanıcı rolünü güncelle
                currentlyUser.UserType = Core.Entitites.UserType.Admin;

                // Güncellemeden önce loglama yap
                Console.WriteLine($"Güncellenmeden önce: UserType = {currentlyUser.UserType}");

                await _userRepository.UpdateAsync(currentlyUser);

                // Güncellemeyi kontrol et
                var updatedUser = await _userRepository.GetAsync(u => u.Id == request.UserId);
                if (updatedUser.UserType != Core.Entitites.UserType.Admin)
                {
                    throw new BusinessException("Kullanıcı rolü güncellenemedi !");
                }

                // Kullanıcıya admin rolü atandı
                await _userOperationClaimRepository.AddAsync(new Domain.Entities.UserOperationClaim
                {
                    UserId = request.UserId,
                    OperationClaimId = 1
                });

                return new AdminRoleCommandResponse();

            }
        }

    }
}
