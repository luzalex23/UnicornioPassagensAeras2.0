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

public class BagagemRepository : Repository<Bagagem>, IBagagemRepository
{
    public BagagemRepository(AppDbContext context) : base(context)
    {
    }

    public Task<List<Bagagem>> GetBagagensByPassagem(int passagemId)
    {
        return _context.Bagagens
            .Where(b => b.PassagemID == passagemId)
            .ToListAsync();
    }

}
