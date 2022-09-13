using AuthenticationJWT.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationJWT.Services
{
    public static class TokenServices
    {
        public static string GenerateToken(User user)
        {
            //classe para gerar o token
            var tokenHandler = new JwtSecurityTokenHandler();

            //encode para array de bytes da minha chave
            var key = Encoding.ASCII.GetBytes(Settings.SecretKey);

            //descreve tudo o que o nosso token possui.
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //tempo de expiração do token
                Expires = DateTime.UtcNow.AddHours(7),

                //credenciais usadas para encriptar e desencriptar o token com base no sha256
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),

                //criar novo claim identity
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Username), //User.Identity.Name
                    new Claim(ClaimTypes.Role, user.Role) //User.IsInRole
                }),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
