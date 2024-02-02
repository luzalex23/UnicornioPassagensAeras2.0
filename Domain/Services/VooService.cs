using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class VooService : IVooService
{
    private readonly IVooRepository _vooRepository;
    public VooService(IVooRepository vooRepository)
    {
        _vooRepository = vooRepository;
    }
    public async Task AtualizarVoo(Voo voo)
    {
        await _vooRepository.Update(voo);
    }

    public async Task CriarVoo(Voo voo)
    {
        await _vooRepository.Add(voo);
    }

    public Task<List<Voo>> ListarVoosDisponiveis(string origem, string destino, DateTime dataPartida, decimal? valorMaximo)
    {
        return _vooRepository.GetVoosDisponiveis(origem, destino, dataPartida);
    }
}
