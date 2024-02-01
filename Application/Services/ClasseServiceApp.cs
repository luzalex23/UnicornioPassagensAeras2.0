
using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;

namespace Application.Services;

public class ClasseServiceApp : IClasseAppService
{
    private readonly IClasseService _classeService;
    private readonly IClasseRepository _classeRepository;
    public ClasseServiceApp(IClasseService classeService, IClasseRepository classeRepository)
    {
        _classeService = classeService;
        _classeRepository = classeRepository;
    }

    public async Task Add(Classe objeto)
    {
        await _classeRepository.Add(objeto);
    }

    public async Task CriarClasse(Classe classe)
    {
        await _classeService.CriarClasse(classe);
    }

    public async Task Delete(Classe objeto)
    {
        await _classeRepository.Delete(objeto); 
    }

    public async Task<Classe> GetEntityById(int Id)
    {
       return await _classeRepository.GetEntityById(Id);
    }

    public async Task<List<Classe>> List()
    {
        return await _classeRepository.List();  
    }

    public async Task<List<Classe>> ListClasse(Classe classe)
    {
       return await _classeRepository.GetClassesByVoo(classe.ClasseID);
    }

    public async Task Update(Classe objeto)
    {
        await _classeRepository.Update(objeto);
    }
}
