using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IClasseAppService : IGenericAppService<Classe>
{
    Task CriarClasse(Classe classe);
    Task<List<Classe>> ListClasse(Classe classeDTO);
}
