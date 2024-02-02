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

public class VooRepository : Repository<Voo>, IVooRepository
{
    public VooRepository(AppDbContext context) : base(context)
    {
    }

    public Task<List<Voo>> GetVoosByAeroportos(string origem, string destino)
    {
        throw new NotImplementedException();
    }

    public Task<List<Voo>> GetVoosDisponiveis(string origem, string destino, DateTime data)
    {
        throw new NotImplementedException();
    }

    public Task<List<Voo>> ListarVoosDisponiveis(string origem, string destino, DateTime dataPartida, decimal? valorMaximo)
    {
        return _context.Voos
            .Include(v => v.AeroportoOrigem)
            .Include(v => v.AeroportoDestino)
            .Where(v =>
                v.AeroportoOrigem.Name.Contains(origem) &&
                v.AeroportoDestino.Name.Contains(destino) &&
                v.DataHoraPartida >= dataPartida &&
                (valorMaximo == null || v.PrecoTotal <= valorMaximo)
            )
            .ToListAsync();
    }
}