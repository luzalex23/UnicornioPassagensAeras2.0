using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;

namespace Domain.Services;

public class CidadeService : ICidadeService
{
    private readonly ICidadeRepository _cidadeRepository;

    public CidadeService(ICidadeRepository cidadeRepository)
    {
        _cidadeRepository = cidadeRepository;
    }

    public async Task<Cidade> GetById(long id)
    {
        return await _cidadeRepository.GetEntityById(id);
    }

    public async Task<List<Cidade>> List()
    {
        return await _cidadeRepository.List();
    }
    public async Task Delete(Cidade cidade)
    {
        await _cidadeRepository.Delete(cidade);
    }
    public async Task Update(Cidade cidade)
    {
        await _cidadeRepository.Update(cidade);
    }

    public async Task GetCidadeByUf(string uf)
    {
       await _cidadeRepository.GetCidadeByUf(uf);
    }

    public async Task Add(Cidade cidade)
    {
        await _cidadeRepository.Add(cidade);
    }
}

