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
    private readonly IBagagemRepository _bagagemRepository;
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
    public async Task<List<Passagem>> ObterPassagensPorCPF(string cpf)
    {
        try
        {


            var passagensDoCliente = await _passagemRepository.ObterPassagensPorCPF(p => ((Passagem)p).Passageiro.Cpf == cpf);

            return passagensDoCliente;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao obter passagens por CPF: {ex.Message}");
        }
    }
    public async Task<List<Passagem>> ComprarPassagens(
        Voo voo,
        Classe classe,
        int quantidadePassagens,
        List<Passageiro> passageiros,
        bool despacharBagagem)
    {
        try
        {
            var passagensCompradas = new List<Passagem>();
            for (int i = 0; i < quantidadePassagens; i++)
            {
                decimal precoTotal = classe.ValorAssento * quantidadePassagens;

                var passagem = new Passagem(
                     precoTotal: precoTotal,
                     classe: classe,
                     voo: voo,
                     passageiro: passageiros[i]
                    );

                await _passagemRepository.Add(passagem);

                if (despacharBagagem)
                {
                    var bagagem = new Bagagem
                    (
                            BagagemID: passagem.PassagemID,
                            passagem: passagem
                     );


                    await _bagagemRepository.Add(bagagem);
                }

                passagensCompradas.Add(passagem);
            }

            return passagensCompradas;
        }
        catch (Exception ex)
        {

            throw new Exception($"Erro ao comprar passagens: {ex.Message}");
        }
    }
    public async Task CancelarCompra(Passagem passagem)
    {
        try
        {
            await _passagemRepository.Delete(passagem);

            var bagagem = await _bagagemRepository.GetEntityById(passagem.PassagemID);
            if (bagagem != null)
            {
                await _bagagemRepository.Delete(bagagem);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao cancelar a compra: {ex.Message}");
        }
    }

    public string EmitirVoucher(Passagem passagem)
    {
        try
        {


            return "Voucher emitido com sucesso";
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao emitir o voucher: {ex.Message}");
        }
    }
}
