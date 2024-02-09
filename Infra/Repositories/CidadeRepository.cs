using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infra.Repositories;

public class CidadeRepository : ICidadeRepository
{
    private readonly AppDbContext _context;

    public CidadeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Add(Cidade cidade)
    {
        _context.Cidades.Add(cidade);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Cidade cidade)
    {
        _context.Cidades.Update(cidade);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Cidade cidade)
    {
        _context.Cidades.Remove(cidade);
        await _context.SaveChangesAsync();
    }

    public async Task<Cidade> GetEntityById(long id)
    {
        return await _context.Cidades.FindAsync(id);
    }

    public async Task<List<Cidade>> List()
    {
        return await _context.Cidades.ToListAsync();
    }

    public async Task<Cidade> GetByName(string name)
    {
        return await _context.Cidades.FirstOrDefaultAsync(c => c.Name == name);
    }

    public async Task<Cidade> GetCidadeByUf(string uf)
    {
        return await _context.Cidades.FirstOrDefaultAsync(c => c.UF == uf);
    }
}
