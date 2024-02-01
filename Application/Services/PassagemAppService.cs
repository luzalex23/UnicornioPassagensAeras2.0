using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class PassagemAppService : IPassagemAppService
{
    private readonly IPassagemService _passagemService;
    private readonly IPassagemRepository _passagemRepository;

    public PassagemAppService(IPassagemService passagemService, IPassagemRepository passagemRepository)
    {
        _passagemService = passagemService;
        _passagemRepository = passagemRepository;
    }

    public async Task Add(Passagem objeto)
    {
        await _passagemRepository.Add(objeto);
    }

    public async Task ComprarPassagem(Passagem passagem)
    {
        await _passagemService.CriarPassagem(passagem);
    }

    public async Task Delete(Passagem objeto)
    {
        await _passagemRepository.Delete(objeto);
    }

    public async Task<Passagem> GetEntityById(int Id)
    {
        return await _passagemRepository.GetEntityById(Id);
    }

    public async Task<List<Passagem>> List()
    {
        return await _passagemRepository.List();
    }

    public async Task Update(Passagem objeto)
    {
        await _passagemRepository.Update(objeto);
    }
}
