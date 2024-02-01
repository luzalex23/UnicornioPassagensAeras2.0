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

public class PassageiroAppService : IPassageiroAppService
{
    private readonly IPassageiroService _passageiroService;
    private readonly IPassageiroRepository _passageiroRepository;   

    public PassageiroAppService(IPassageiroService passageiroService, IPassageiroRepository passageiroRepository)
    {
        _passageiroService = passageiroService;
        _passageiroRepository = passageiroRepository;
    }
    
    public async Task Add(Passageiro objeto)
    {
        await _passageiroRepository.Add(objeto);
    }

    public async Task CadastrarPassageiro(Passageiro passageiro)
    {
        await _passageiroService.CadastrarPassageiro(passageiro);
    }

    public async Task Delete(Passageiro objeto)
    {
        await _passageiroRepository.Delete(objeto);
    }

    public async Task<Passageiro> GetEntityById(int Id)
    {
        return await _passageiroRepository.GetEntityById(Id);
    }

    public async Task<List<Passageiro>> List()
    {
        return await _passageiroRepository.List();
    }

    public async Task<Passageiro> ObterPassageiroPorCPF(string cpf)
    {
       return await _passageiroService.ObterPassageiroPorCPF(cpf);
    }

    public async Task Update(Passageiro objeto)
    {
        await _passageiroRepository.Update(objeto);
    }
}
