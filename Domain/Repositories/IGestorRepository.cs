using Domain.Entities;

namespace Domain.Repositories
{
    public interface IGestorRepository : IRepository<Gestor>
    {
        Task<Gestor> GetGestorByUsername(string username);
        Task<bool> CheckCredentials(string username, string password);

    }
}
