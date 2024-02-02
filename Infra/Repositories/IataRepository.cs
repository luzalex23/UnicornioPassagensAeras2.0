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

public class IataRepository : IRepository<Iata>
{
    private readonly AppDbContext _context;

    public IataRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Add(Iata objeto)
    {
        _context.Iatas.Add(objeto);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Iata objeto)
    {
        _context.Iatas.Remove(objeto);
        await _context.SaveChangesAsync();
    }

    public async Task<Iata?> GetByName(string name)
    {
        return await _context.Iatas
            .FirstOrDefaultAsync(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public async Task<Iata> GetEntityById(long id)
    {
        return await _context.Iatas.FindAsync(id) ?? throw new InvalidOperationException("Iata não encontrada");

    }

    public Task<List<Iata>> List()
    {
        return _context.Iatas.ToListAsync();
    }

    public async Task Update(Iata objeto)
    {
        _context.Iatas.Update(objeto);
        await _context.SaveChangesAsync();
    }
}
