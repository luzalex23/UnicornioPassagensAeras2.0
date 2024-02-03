using Domain.Entities;

namespace Domain.Services.InterfacesServicos;

public interface IVooService : IServiceGeneric<Voo>
{
    Task CriarVoo(Voo voo);
    Task AtualizarVoo(Voo voo);
    Task<List<Voo>> ListarVoosDisponiveis(string origem, string destino, DateTime dataPartida, decimal? valorMaximo);
}
