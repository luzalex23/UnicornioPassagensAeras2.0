using Domain.Entities;
namespace Domain.Services.InterfacesServicos;
public interface ICidadeService : IServiceGeneric<Cidade>
{
    Task GetCidadeByUf(string uf);
}
