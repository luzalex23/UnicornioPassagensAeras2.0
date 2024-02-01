using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IVooAppService : IGenericAppService<Voo>
{
    Task CriarVoo(Voo voo);
    Task<List<Voo>> ListarVoosDisponiveis(string origem, string destino, DateTime dataPartida, decimal? valorMaximo);
}
