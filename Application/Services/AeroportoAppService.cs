using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;

namespace Application.Services;

public class AeroportoAppService : IAeroportoAppService
{
    private readonly IAeroportoService _aeroportoService;
    private readonly IAeroportoRepository _aeroportoRepository;

    public AeroportoAppService(IAeroportoRepository aeroportoRepository, IAeroportoService aeroportoService)
    {
        _aeroportoService = aeroportoService;
        _aeroportoRepository = aeroportoRepository;
    }

    public async Task Add(Aeroporto objeto)
    {
        await _aeroportoRepository.Add(objeto); 
    }

    public async Task CriarAeroporto(Aeroporto aeroporto)
    {
        // Verifica se o código IATA já está associado a algum aeroporto
        var aeroportoExistente = await _aeroportoRepository.GetAeroportoByCodigoIATA(aeroporto.CodigoIATA);

        if (aeroportoExistente != null)
        {
            throw new InvalidOperationException("Código IATA já está associado a outro aeroporto, por favor use outro IATA.");
        }
         await _aeroportoRepository.Add(aeroporto);
    }


    public async Task Delete(Aeroporto objeto)
    {
        await _aeroportoRepository.Delete(objeto);
    }

    public async Task<Aeroporto> GetEntityById(int Id)
    {
        return await _aeroportoRepository.GetEntityById(Id);
    }

    public async Task<List<Aeroporto>> List()
    {
        return await _aeroportoRepository.List();
    }
    public async Task Update(Aeroporto objeto)
    {
        await _aeroportoRepository.Update(objeto);
    }
}
