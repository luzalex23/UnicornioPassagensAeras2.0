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

public class CompraRepository : Repository<Compra>, ICompraRepository
{
    public CompraRepository(AppDbContext context) : base(context)
    {
    }

    public Task<List<Compra>> GetComprasByPassageiro(string cpf)
    {
        return _context.Compras
            .Where(c => c.Passageiro.Cpf == cpf)
            .ToListAsync();
    }


    public Task<List<Compra>> ListarComprasPorData(DateTime data)
    {
        return _context.Compras
            .Where(c => c.CompraDate.Date == data.Date)
            .ToListAsync();
    }

}
