using Domain.Entities;
namespace Domain.Services.InterfacesServicos;

public interface IAeroportoService
{
    Task CriarAeroporto(Aeroporto aeroporto);
    Task AtualizarAeroporto(Aeroporto aeroporto);

}
