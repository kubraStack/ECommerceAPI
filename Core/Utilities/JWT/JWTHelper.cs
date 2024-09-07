using Core.Entitites;
using Core.Extentions;
using Core.Utilities.Encryption;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.JWT
{
    public class JWTHelper : ITokenHelper
    {
        private readonly TokenOptions _tokenOptions;

        public JWTHelper(TokenOptions tokenOptions)
        {
            _tokenOptions = tokenOptions;
        }

        public AccessToken CreateToken(BaseUser user, List<BaseOperationClaim> operationClaims)
        {
            //Özellikleri oku ve token'i yaz.

            //Token'in sona erme süresi
            DateTime expirationTime = DateTime.Now.AddMinutes(_tokenOptions.ExpirationTime);

            //Token için kriptografik anahtar
            SecurityKey key = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);

            //Token'in doğrulama imzası
            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            JwtSecurityToken jwt = new JwtSecurityToken(
                 issuer: _tokenOptions.Issuer,
                 audience: _tokenOptions.Audience,
                 claims: SetAllClaims(user, operationClaims.Select(i => i.Name).ToList()),
                 notBefore: DateTime.Now,
                 expires: expirationTime,
                 signingCredentials: signingCredentials
            );

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
            string jwtToken = jwtSecurityTokenHandler.WriteToken(jwt);
            return new AccessToken() {  Token = jwtToken, ExpirationTime = expirationTime };
        }

        protected IEnumerable<Claim> SetAllClaims(BaseUser user, List<string> operationClaims) { 
        
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, user.FirstName));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));

            foreach (var operationClaim in operationClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, operationClaim));   
            }
            claims.Add(new Claim("UserType", UserTypeExtentions.ToDescriptionString(user.UserType)));
            return claims;
        }

    }
}
