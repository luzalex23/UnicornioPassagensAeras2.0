using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class AeroportoRepository : IAeroportoRepository
{
    public readonly AppDbContext _context;

    public AeroportoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Add(Aeroporto aeroporto)
    {
        _context.Aeroportos.Add(aeroporto);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Aeroporto aeroporto)
    {
        _context.Aeroportos.Update(aeroporto);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Aeroporto aeroporto)
    {
        _context.Aeroportos.Remove(aeroporto);
        await _context.SaveChangesAsync();
    }

    public async Task<Aeroporto> GetEntityById(long id)
    {
        return await _context.Aeroportos.FindAsync(id);
    }

    public async Task<List<Aeroporto>> List()
    {
        return await _context.Aeroportos.ToListAsync();
    }

    public async Task<Aeroporto> GetByName(string name)
    {
        return await _context.Aeroportos.FirstOrDefaultAsync(a => a.Name == name);
    }

    public async Task<Aeroporto> GetAeroportoByCodigoIATA(string codigoIATA)
    {
        return await _context.Aeroportos.Include(a => a.Iata).FirstOrDefaultAsync(a => a.Iata.Name == codigoIATA);
    }

    public async Task<List<Aeroporto>> GetAeroportosByCidade(string nomeCidade)
    {
        return await _context.Aeroportos.Include(a => a.Cidade).Where(a => a.Cidade.Name == nomeCidade).ToListAsync();
    }

    public async Task<List<Aeroporto>> ListarAeroportoPorNome(string nome)
    {
        return await _context.Aeroportos.Where(a => a.Name.Contains(nome)).ToListAsync();
    }
}
