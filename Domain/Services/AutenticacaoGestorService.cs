using Domain.Repositories;
using Domain.Services.InterfacesServicos;

namespace Domain.Services;

public class AutenticacaoGestorService : IAutenticacaoGestorService
{
    private readonly IGestorRepository _gestorRepository;
    private readonly ITokenService _tokenService;


    public AutenticacaoGestorService(IGestorRepository gestorRepository, ITokenService tokenService)
    {
        _gestorRepository = gestorRepository;
        _tokenService = tokenService;

    }

    public async Task<string?> AutenticarGestor(string username, string password)
    {
        if (await _gestorRepository.CheckCredentials(username, password))
        {
            var token = _tokenService.GenerateToken(username);
            return token;
        }

        return null;
    }
}
