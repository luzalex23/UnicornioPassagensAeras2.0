using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;


public class IataRepository : IIataRepository
{
    private readonly AppDbContext _context;

    public IataRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Add(Iata Iata)
    {
        _context.Iatas.Add(Iata);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Iata Iata)
    {
        _context.Iatas.Update(Iata);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Iata Iata)
    {
        _context.Iatas.Remove(Iata);
        await _context.SaveChangesAsync();
    }

    public async Task<Iata> GetEntityById(long id)
    {
        return await _context.Iatas.FindAsync(id);
    }

    public async Task<List<Iata>> List()
    {
        return await _context.Iatas.ToListAsync();
    }

    public async Task<Iata> GetByName(string name)
    {
        return await _context.Iatas.FirstOrDefaultAsync(i => i.Name == name);
    }

}

