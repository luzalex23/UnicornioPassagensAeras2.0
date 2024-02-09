using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.InterfacesServicos;

public interface IIataService : IServiceGeneric<Iata>
{
    Task<Iata> GetByNome(string nome);
}
