using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

public class AeroportoRepository : Repository<Aeroporto>, IAeroportoRepository
{
    public AeroportoRepository(AppDbContext context) : base(context)
    {
    }

    public Task<List<Aeroporto>> ListarAeroportoPorNome(string nome)
    {
        return _context.Aeroportos
            .Where(a => a.Name.Contains(nome))
            .ToListAsync();
    }

    public async Task<Aeroporto?> GetAeroportoByCodigoIATA(string codigoIATA)
    {
        return await _context.Aeroportos
            .FirstOrDefaultAsync(a => a.CodigoIATA.Equals(codigoIATA, StringComparison.OrdinalIgnoreCase));
    }
    public Task<List<Aeroporto>> GetAeroportosByCidade(string nomeCidade)
    {
        return _context.Aeroportos
            .Where(a => a.Cidade.Name.Contains(nomeCidade))
            .ToListAsync();
    }
}