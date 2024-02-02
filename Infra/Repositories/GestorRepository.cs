using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class GestorRepository : Repository<Gestor>, IGestorRepository
    {
        public GestorRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Gestor> GetGestorByUsername(string username)
        {
            return await _context.Gestores.FirstOrDefaultAsync(g => g.Username == username);
        }

        public async Task<bool> CheckCredentials(string username, string password)
        {
            var gestor = await _context.Gestores.FirstOrDefaultAsync(g => g.Username == username && g.PasswordHash == password);
            return gestor != null;
        }
    }
}
