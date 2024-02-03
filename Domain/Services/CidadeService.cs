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

    public async Task AtualizarCidade(Cidade cidade)
    {
        await _cidadeRepository.Update(cidade);
    }

    public async Task CriarCidade(Cidade cidade)
    {
        var existingCidade =  _cidadeRepository.GetCidadeByNome(cidade.Name);
        if(existingCidade != null)
        {
            throw new InvalidOperationException("Cidade com o mesmo Nome já existe.");

        }
         await _cidadeRepository.Add(cidade);

    }

    public Task<Cidade> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Cidade> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Cidade>> List()
    {
        throw new NotImplementedException();
    }
}
