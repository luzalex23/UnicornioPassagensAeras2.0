using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class IataService : IIataService
{
    private readonly IRepository<Iata>_repository;
    public IataService(IRepository<Iata> repository)
    {
        _repository = repository;
    }
    public async Task AtualizarIata(Iata iata)
    {
        await _repository.Update(iata);
    }

    public async Task CriarIata(Iata iata)
    {
        await _repository.Add(iata);
    }
}
