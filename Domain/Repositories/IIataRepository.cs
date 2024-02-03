using Domain.Entities;

namespace Domain.Repositories;

public interface IIataRepository : IRepository<Iata>
{
    Task<List<Iata>> GetIataIdByAeroporto(long iataId);
}
