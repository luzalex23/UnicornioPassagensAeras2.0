using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;

namespace Domain.Services;

public class PassageiroService : IPassageiroService
{
    private readonly IPassageiroRepository _passageiroRepository;
    public PassageiroService(IPassageiroRepository passageiroRepository)
    {
        _passageiroRepository = passageiroRepository;
    }
    public async Task AtulaizarPassageiro(Passageiro passageiro)
    {
        await _passageiroRepository.Update(passageiro);
    }

    public async Task CadastrarPassageiro(Passageiro passageiro)
    {
        await _passageiroRepository.Add(passageiro);
    }

    public async Task<Passageiro> ObterPassageiroPorCPF(string cpf)
    {
        return await _passageiroRepository.GetPassageiroByCPF(cpf);
    }
}
