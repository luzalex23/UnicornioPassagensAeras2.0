using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;

public interface IVooRepository : IRepository<Voo>
{
    Task<List<Voo>> GetVoosByAeroportos(string origem, string destino);
    Task<List<Voo>> GetVoosDisponiveis(string origem, string destino, DateTime data);
}