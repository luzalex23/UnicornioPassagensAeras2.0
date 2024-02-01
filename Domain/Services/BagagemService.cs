using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;

namespace Domain.Services;

public class BagagemService : IBagemService
{
    private readonly IBagagemRepository _bagagemRepository;
    public BagagemService(IBagagemRepository bagagemRepository)
    {
        _bagagemRepository = bagagemRepository;
    }
    public async Task AtualizarBagagem(Bagagem bagagem)
    {
        await _bagagemRepository.Update(bagagem);
    }

    public async Task CriarBagem(Bagagem bagagem)
    {
        await _bagagemRepository.Add(bagagem);
    }
}
