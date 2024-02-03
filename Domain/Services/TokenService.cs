using Domain.Services.InterfacesServicos;
using Infra.Services;
using System.Security.Claims;
namespace Domain.Services;

public class TokenService : ITokenService
{
    private readonly TokenGenerator _tokenGenerator;
    private readonly TokenValidator _tokenValidator;

    public TokenService(TokenGenerator tokenGenerator, TokenValidator tokenValidator)
    {
        _tokenGenerator = tokenGenerator;
        _tokenValidator = tokenValidator;
    }

    public string GenerateToken(string userId, string username)
    {
        return _tokenGenerator.GenerateToken(userId, username);
    }

    public ClaimsPrincipal ValidateToken(string token)
    {
        return _tokenValidator.ValidateToken(token);
    }
}