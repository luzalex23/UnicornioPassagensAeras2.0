using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;
public class AeroportoService : IAeroportoService
{
    private readonly IAeroportoRepository _aeroportoRepository;

    public AeroportoService(IAeroportoRepository aeroportoRepository)
    {
        _aeroportoRepository = aeroportoRepository;
    }

    public async Task<List<Aeroporto>> ListarAeroportoPorNome(string nome)
    {
        return await _aeroportoRepository.ListarAeroportoPorNome(nome);
    }

    public async Task<Aeroporto> GetAeroportoByCodigoIATA(string codigoIATA)
    {
        return await _aeroportoRepository.GetAeroportoByCodigoIATA(codigoIATA);
    }

    public async Task<List<Aeroporto>> GetAeroportosByCidade(string nomeCidade)
    {
        return await _aeroportoRepository.GetAeroportosByCidade(nomeCidade);
    }

    public async Task<Aeroporto> GetById(long id)
    {
        return await _aeroportoRepository.GetEntityById(id);
    }

    public async Task<List<Aeroporto>> List()
    {
        return await _aeroportoRepository.List();
    }

    public async Task Add(Aeroporto aeroporto)
    {
        await _aeroportoRepository.Add(aeroporto);
    }

    public async Task Update(Aeroporto aeroporto)
    {
        await _aeroportoRepository.Update(aeroporto);
    }

    public async Task Delete(Aeroporto aeroporto)
    {
        await _aeroportoRepository.Delete(aeroporto);
    }
}
