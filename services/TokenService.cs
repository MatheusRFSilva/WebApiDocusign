using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace WebApiDocusign.Services
{
    public static class TokenService
    {
        public static string GenerateToken(Settings settings)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(settings.RsaPublicKey);
            using RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(key, out _);
            var privateKey = Encoding.ASCII.GetBytes(settings.RsaPrivateKey);

            rsa.ImportRSAPrivateKey(privateKey, out _);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("iss", settings.ClientId),
                    new Claim("sub", "6a6fa884-5aa4-4b3b-838a-5fe77101fb4e"),
                    new Claim("aud", "https://account-d.docusign.com"),
                    new Claim("scope","signature impersonation")
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new RsaSecurityKey(rsa), SecurityAlgorithms.RsaSha256)
                {
                    CryptoProviderFactory = new CryptoProviderFactory { CacheSignatureProviders = false }
                }
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}