using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infra.Services;

public class TokenGenerator
{
    private readonly JwtSettings _jwtSettings;

    public TokenGenerator(JwtSettings jwtSettings)
    {
        _jwtSettings = jwtSettings;
    }

    public string GenerateToken(string userId, string username)
    {
        var claims = new[]
        {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(JwtRegisteredClaimNames.UniqueName, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationMinutes),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}