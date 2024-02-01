using Domain.Entities;


namespace Domain.Services.InterfacesServicos;

public interface ICidadeService
{
    Task CriarCidade(Cidade cidade);
    Task AtualizarCidade(Cidade cidade);
}
