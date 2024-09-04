using Application.Repositories;
using Core.Utilities.Hashing;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.ChangePassword.Commands
{
    public class ChangePasswordCommand : IRequest<ChangePasswordCommandResponse>
    {
        [Required]
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }

        public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, ChangePasswordCommandResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ILogger<ChangePasswordCommandHandler> _logger;

            public ChangePasswordCommandHandler(IUserRepository userRepository, IHttpContextAccessor httpContextAccessor, ILogger<ChangePasswordCommandHandler> logger)
            {
                _userRepository = userRepository;
                _httpContextAccessor = httpContextAccessor;
                _logger = logger;
            }

            public async  Task<ChangePasswordCommandResponse> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
            {
               var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (userId == null)
                {
                    return new ChangePasswordCommandResponse
                    {
                        Success = false,
                        Message = "User not authenticated"
                    };
                }

                var user = await _userRepository.GetAsync(u => u.Id.ToString() == userId);
                if (user == null)
                {
                    return new ChangePasswordCommandResponse
                    {
                        Success = false,
                        Message = "User not found"
                    };
                }

                HashingHelper.CreatePasswordHash(request.NewPassword, out byte[] newHash, out  byte[] newSalt);
                user.PasswordHash = newHash;
                user.PasswordSalt = newSalt;

                await _userRepository.UpdateAsync(user);
                return new ChangePasswordCommandResponse
                {
                    Success = true,
                    Message = "Password changed successfully"
                };
            }
        }
    }
}
