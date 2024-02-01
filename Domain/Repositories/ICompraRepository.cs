using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;

public interface ICompraRepository : IRepository<Compra>
{
    Task<List<Compra>> GetComprasByPassageiro(string cpf);
    Task<List<Compra>> ListarComprasPorData(DateTime data);

}
