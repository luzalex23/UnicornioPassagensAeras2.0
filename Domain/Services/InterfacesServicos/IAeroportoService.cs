using Domain.Entities;
namespace Domain.Services.InterfacesServicos;

public interface IAeroportoService : IServiceGeneric<Aeroporto>
{
    Task<List<Aeroporto>> ListarAeroportoPorNome(string nome);
}
