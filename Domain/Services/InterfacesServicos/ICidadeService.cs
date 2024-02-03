using Domain.Entities;


namespace Domain.Services.InterfacesServicos;

public interface ICidadeService : IServiceGeneric<Cidade>
{
    Task CriarCidade(Cidade cidade);
    Task AtualizarCidade(Cidade cidade);
}
