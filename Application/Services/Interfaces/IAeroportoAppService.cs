using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IAeroportoAppService : IGenericAppService<Aeroporto>
{
    Task CriarAeroporto(Aeroporto aeroporto);

}
