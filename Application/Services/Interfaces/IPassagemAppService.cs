using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IPassagemAppService : IGenericAppService<Passagem>
{
    Task ComprarPassagem(Passagem passagem);
}
