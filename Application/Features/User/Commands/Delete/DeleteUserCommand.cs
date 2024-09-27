using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.Delete
{
    public class DeleteUserCommand : IRequest<DeleteUserCommandResponse>
    {
       

        public class UserDeleteCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserCommandResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public UserDeleteCommandHandler(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                // Oturum açmış kullanıcının ID'sini alıyoruz.
                var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                // Kullanıcıyı veritabanından buluyoruz.
                var userToDelete = await _userRepository.GetAsync(u => u.Id == userId);
                if (userToDelete == null)
                {
                    throw new BusinessException("Kullanıcı bulunamadı.");
                }

                // Kullanıcıyı silme işlemi.
                await _userRepository.SoftDeleteAsync(userToDelete);

                // Başarılı yanıt dönüyoruz.
                return new DeleteUserCommandResponse
                {
                    Success = true,
                    Message = "Kullanıcı başarıyla silindi."
                };
            }
        }
    }
}
