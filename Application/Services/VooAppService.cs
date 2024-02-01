using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services;
using Domain.Services.InterfacesServicos;

namespace Application.Services;

public class VooAppService : IVooAppService
{

    private readonly IVooService _vooService;
    private readonly IVooRepository _vooRepository;
    public VooAppService(IVooService vooService, IVooRepository vooRepository)
    {
        _vooService = vooService;
        _vooRepository = vooRepository;
    }
    
    public async Task Add(Voo objeto)
    {
        await _vooRepository.Add(objeto);
    }

    public async Task CriarVoo(Voo voo)
    {
        await _vooService.CriarVoo(voo);
    }

    public async Task Delete(Voo objeto)
    {
        await _vooRepository.Delete(objeto);
    }

    public async Task<Voo> GetEntityById(int Id)
    {
        return await _vooRepository.GetEntityById(Id);
    }

    public async Task<List<Voo>> List()
    {
        return await _vooRepository.List();
    }

    public async Task<List<Voo>> ListarVoosDisponiveis(string origem, string destino, DateTime dataPartida, decimal? valorMaximo)
    {
        return await _vooRepository.GetVoosDisponiveis(origem, destino, dataPartida);
    }

    public async Task Update(Voo objeto)
    {
        await _vooRepository.Update(objeto);    
    }
}
