using Domain.Entities;
namespace Domain.Services.InterfacesServicos;

public interface IAeroportoService
{
    Task CriarAeroporto(Aeroporto aeroporto);
    Task AtualizarAeroporto(Aeroporto aeroporto);
    Task<List<Aeroporto>> ListarAeroportoPorNome(string nome);
    Task<Aeroporto> GetAeroportoByCodigoIATA(string codigoIATA);
}
