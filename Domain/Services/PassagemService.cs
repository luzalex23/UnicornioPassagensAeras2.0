using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class PassagemService : IPassagemService
{
    private readonly IPassagemRepository _passagemRepository;
    public PassagemService(IPassagemRepository passagemRepository)
    {
        _passagemRepository = passagemRepository;
    }
   

    public async Task CriarPassagem(Passagem passagem)
    {
        await _passagemRepository.Update(passagem);
    }

    public async Task AtualizarPassagem(Passagem passagem)
    {
        await _passagemRepository.Add(passagem);
    }
}
