using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories;

public class ClasseRepository : Repository<Classe>, IClasseRepository
{
    public ClasseRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<Classe>> GetClassesByVoo(long vooId)
    {
        return await _context.Classes
            .Where(c => c.VooID == vooId)
            .ToListAsync();
    }

}
