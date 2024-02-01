using Domain.Entities;

namespace Domain.Services.InterfacesServicos;

public interface IBagemService
{
    Task CriarBagem(Bagagem bagagem);
    Task AtualizarBagagem(Bagagem bagagem);
}
