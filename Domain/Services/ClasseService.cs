using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class ClasseService : IClasseService
{
    private readonly IClasseRepository _classeRepository;
    public ClasseService(IClasseRepository classeRepository)
    {
        _classeRepository = classeRepository;
    }
    public async Task AtualizarClasse(Classe classe)
    {
        await _classeRepository.Update(classe);
    }

    public async Task CriarClasse(Classe classe)
    {
        await _classeRepository.Add(classe);
    }
    public decimal CalcularValorTotal(Classe classe)
    {

        decimal taxaBasePorAssento = 100.0m;

        decimal valorTotal = taxaBasePorAssento * classe.ValorAssento;

        return valorTotal;
    }

    public Task<Classe> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Classe> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Classe>> List()
    {
        throw new NotImplementedException();
    }
}
