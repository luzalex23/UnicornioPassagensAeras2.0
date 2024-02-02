using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;

public interface IAeroportoRepository : IRepository<Aeroporto>
{
    Task<Aeroporto> GetAeroportoByCodigoIATA(string codigoIATA);
    Task<List<Aeroporto>> GetAeroportosByCidade(string nomeCidade);
    Task<List<Aeroporto>> ListarAeroportoPorNome(string nome);

    //Task GetByCodigoIATA(string codigoIATA);
}
