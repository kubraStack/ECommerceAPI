using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.UpdateByAdmin
{
    public class UpdateUserByAdminCommand : IRequest<UpdateUserByAdminCommandResponse>, ISequredRequest
    {
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Gender { get; set; }
        public string[] RequiredRoles => ["Admin"];


        public class UpdateUserByAdminCommandHandler : IRequestHandler<UpdateUserByAdminCommand, UpdateUserByAdminCommandResponse>
        {
            private readonly IUserRepository _userRepository;

            public UpdateUserByAdminCommandHandler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<UpdateUserByAdminCommandResponse> Handle(UpdateUserByAdminCommand request, CancellationToken cancellationToken)
            {
               var userToUpdate = await _userRepository.GetAsync(u => u.Id == request.UserId);

                userToUpdate.Email = request.Email != null ? request.Email : userToUpdate.Email;
                userToUpdate.FirstName = request.FirstName != null ? request.FirstName : userToUpdate.FirstName;
                userToUpdate.LastName = request.LastName != null ? request.LastName : userToUpdate.LastName;
                userToUpdate.PhoneNumber = request.PhoneNumber != null ? request.PhoneNumber : userToUpdate.PhoneNumber;
                userToUpdate.Gender = request.Gender != null ? request.Gender : userToUpdate.Gender;

                await _userRepository.UpdateAsync(userToUpdate);
                return new();
            }
        }
    }
}
