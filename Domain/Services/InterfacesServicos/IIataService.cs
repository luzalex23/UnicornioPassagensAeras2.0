using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.InterfacesServicos;

public interface IIataService
{
    Task CriarIata(Iata iata);
    Task AtualizarIata(Iata iata);
    Task<Iata> GetByNome(string nome);

}
