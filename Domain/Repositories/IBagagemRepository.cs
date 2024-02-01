using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;

public interface IBagagemRepository : IRepository<Bagagem>
{
    Task<List<Bagagem>> GetBagagensByPassagem(int passagemId);
}
