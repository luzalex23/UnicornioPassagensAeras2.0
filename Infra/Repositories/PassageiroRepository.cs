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

public class PassageiroRepository : Repository<Passageiro>, IPassageiroRepository
{
    public PassageiroRepository(AppDbContext context) : base(context)
    {
    }

    public Task<Passageiro?> GetPassageiroByCPF(string cpf)
{
        return _context.Passageiros
            .FirstOrDefaultAsync(p => p.Cpf == cpf);
    }

    public Task<Passageiro?> GetPassageiroByIdade(int idade)
    {
        return _context.Passageiros
            .FirstOrDefaultAsync(p => p.idade == idade);
    }

    public Task<Passageiro?> GetPassageiroByName(string nome)
    {
        return _context.Passageiros
            .FirstOrDefaultAsync(p => p.Name == nome);
    }

}
