using Domain.Entities;

namespace Domain.Services.InterfacesServicos;

public interface IBagagemService
{
    Task CriarBagem(Bagagem bagagem);
    Task AtualizarBagagem(Bagagem bagagem);
}
