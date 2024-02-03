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

    public Task<Voo> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Voo> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Voo>> List()
    {
        throw new NotImplementedException();
    }

    public Task<List<Voo>> ListarVoosDisponiveis(string origem, string destino, DateTime dataPartida, decimal? valorMaximo)
    {
        return _vooRepository.GetVoosDisponiveis(origem, destino, dataPartida);
    }
    public bool ValidarAeroportosOrigemDestino(Aeroporto origem, Aeroporto destino)
    {
        if (origem.CodigoIATA == destino.CodigoIATA)
        {
            return false;

        }
        if (origem.Cidade.Name == destino.Cidade.Name)
        {
            return false;
        }
        // Se chegou até aqui, os aeroportos são válidos
        return true;

    }
    public bool VerificarDisponibilidadeAssentos(Voo voo, Classe classe, int quantidadePassagens)
    {
        var classeNoVoo = voo.Classes.FirstOrDefault(c => c.TipoClasse == classe.TipoClasse);

        return classeNoVoo != null && classeNoVoo.QuantidadeAssentos >= quantidadePassagens;
    }
}
