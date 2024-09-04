using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.Update
{
    public class UpdateUserCommand : IRequest<UpdateUserCommandResponse>
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Gender { get; set; }

        public class UserUpdateCommandHandler : IRequestHandler<UpdateUserCommand, UpdateUserCommandResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public UserUpdateCommandHandler(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
            {
                var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                var isMailExist = await _userRepository.GetAsync(u => u.Email == request.Email);

                if (isMailExist != null)
                {
                    throw new Exception("Bu mail adresi kullanılıyor");
                }

                var userToUpdate = await _userRepository.GetAsync(u => u.Id == currentUserId);

                userToUpdate.Email = request.Email != null ? request.Email : userToUpdate.Email;
                userToUpdate.FirstName = request.FirstName != null ? request.FirstName : userToUpdate.FirstName;
                userToUpdate.LastName = request.LastName != null ? request.LastName : userToUpdate.LastName;
                userToUpdate.PhoneNumber = request.PhoneNumber != null ? request.PhoneNumber : userToUpdate.PhoneNumber;
                userToUpdate.Gender = request.Gender != null ? request.Gender : userToUpdate.Gender;

                await _userRepository.UpdateAsync(userToUpdate);
                return new(); //Method sonlandırıldı
            }
        }
    }
}
