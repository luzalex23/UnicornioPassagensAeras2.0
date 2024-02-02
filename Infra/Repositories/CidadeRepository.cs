using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infra.Repositories;

public class CidadeRepository : Repository<Cidade>, ICidadeRepository
{
    public CidadeRepository(AppDbContext context) : base(context)
    {
    }

    public Task<Cidade?> GetCidadeByNome(string nome)
    {
        return _context.Cidades
            .FirstOrDefaultAsync(c => c.Name == nome);
    }
}
