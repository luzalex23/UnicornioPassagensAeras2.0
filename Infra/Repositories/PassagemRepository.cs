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

public class PassagemRepository : Repository<Passagem>, IPassagemRepository
{
    public PassagemRepository(AppDbContext context) : base(context)
    {
    }

    public Task<List<Passagem>> GetPassagensByCompra(int compraId)
    {
        return _context.Passagens
            .Where(p => p.CompraID == compraId)
            .ToListAsync();
    }

    public Task<List<Passagem>> GetPassagensByVoo(int vooId)
    {
        return _context.Passagens
            .Where(p => p.VooID == vooId)
            .ToListAsync();
    }

}
