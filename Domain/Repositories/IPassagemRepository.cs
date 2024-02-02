using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;

public interface IPassagemRepository : IRepository<Passagem>
{
    Task<List<Passagem>> GetPassagensByVoo(int vooId);
    Task<List<Passagem>> GetPassagensByCompra(int compraId);
    Task<List<Passagem>> ObterPassagensPorCPF(Func<object, bool> value);
}
