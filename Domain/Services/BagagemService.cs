using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;

namespace Domain.Services;

public class BagagemService : IBagagemService
{
    private readonly IBagagemRepository _bagagemRepository;
    public BagagemService(IBagagemRepository bagagemRepository)
    {
        _bagagemRepository = bagagemRepository;
    }
    public async Task AtualizarBagagem(Bagagem bagagem)
    {
        await _bagagemRepository.Update(bagagem);
    }

    public async Task CriarBagem(Bagagem bagagem)
    {
        await _bagagemRepository.Add(bagagem);
    }
    public decimal CalcularTaxaDespacho(Bagagem bagagem)
    {

        var valorAssento = bagagem.Passagem.Classe.ValorAssento;
        var taxaDespacho = 0.1m * valorAssento;

        return taxaDespacho;
    }

    public string EmitirEtiqueta(Bagagem bagagem)
    {
        var etiqueta = $"Etiqueta emitida para a bagagem {bagagem.BagagemID} do passageiro {bagagem.Passagem.Passageiro.Name}";
        return etiqueta;

    }
}
