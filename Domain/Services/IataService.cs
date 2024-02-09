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
    private readonly IIataRepository _iataRepository;

    public IataService(IIataRepository iataRepository)
    {
        _iataRepository = iataRepository;
    }
    public async Task<List<Iata>> ListarIATAs()
    {
        return await _iataRepository.List();
    }

    public async Task<Iata> GetIATAById(long id)
    {
        return await _iataRepository.GetEntityById(id);
    }

    public async Task<Iata> GetByNome(string nome)
    {
        return  await _iataRepository.GetByName(nome);
    }

    public async Task<Iata> GetById(long IataId)
    {
        return await _iataRepository.GetEntityById(IataId);
    }

    public async Task<List<Iata>> List()
    {
        return await _iataRepository.List();
    }

    public async Task Add(Iata iata)
    {
        var existingIata = _iataRepository.GetByName(iata.Name);
        if (existingIata != null)
        {
            throw new InvalidOperationException("CodigoIATA já existente e relacionado a um aeroporto.");
        }
        await _iataRepository.Add(iata);
    }

    public async Task Update(Iata iata)
    {
        await _iataRepository.Update(iata);
    }

    public async Task Delete(Iata iata)
    {
        await _iataRepository.Delete(iata);
    }
}
