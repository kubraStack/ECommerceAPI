using Application.Repositories;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Hashing;
using Core.Utilities.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.Login
{
    public class LoginCommand : IRequest<AccessToken>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public class LoginCommandHandler : IRequestHandler<LoginCommand, AccessToken>
        {
            private readonly IUserRepository _userRepository;
            private readonly ITokenHelper _tokenHelper;
            private readonly IUserOperationClaimRepository _userOperationClaimRepository;

            public LoginCommandHandler(IUserRepository userRepository, ITokenHelper tokenHelper, IUserOperationClaimRepository userOperationClaimRepository)
            {
                _userRepository = userRepository;
                _tokenHelper = tokenHelper;
                _userOperationClaimRepository = userOperationClaimRepository;
            }

            public async Task<AccessToken> Handle(LoginCommand request, CancellationToken cancellationToken)
            {
                Domain.Entities.User? user = await _userRepository.GetAsync(i => i.Email == request.Email);
                if (user == null) {
                    throw new BusinessException("Giriş Başarısız");
                }

                bool isPasswordMatch = HashingHelper.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt);
                if (!isPasswordMatch) {
                    throw new BusinessException("Giriş Başarısız");
                }


                List<UserOperationClaim> userOperationClaims = await _userOperationClaimRepository
                     .GetListAsync(i => i.UserId == user.Id, include: i => i.Include(i => i.OperationClaim));

                // Kullanıcıya ait claim'leri oluştur
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email) // E-posta claim'i ekleyebilirsiniz
                };

                // Kullanıcının sahip olduğu rol veya işlemler
                foreach (var operationClaim in userOperationClaims)
                {
                    claims.Add(new Claim(ClaimTypes.Role, operationClaim.OperationClaim.Name)); // Rol bilgisi ekliyoruz
                }
                //Token oluştur
                var token = _tokenHelper.CreateToken(user, userOperationClaims.Select(i => (Core.Entitites.BaseOperationClaim)i.OperationClaim).ToList());
                return token;

                
               
            }
        }
    }
}
