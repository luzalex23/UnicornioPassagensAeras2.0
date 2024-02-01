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

public class CompraAppService : ICompraAppService
{
    private readonly ICompraService _compraService;
    private readonly ICompraRepository _compraRepository;
    public CompraAppService(ICompraService compraService, ICompraRepository compraRepository)
    {
        _compraService = compraService;
        _compraRepository = compraRepository;
    }

    public async Task Add(Compra objeto)
    {
        await _compraRepository.Add(objeto);
    }

    public async Task AtualizarCompra(Compra compra)
    {
        await _compraService.AtualizarCompra(compra);   
    }

    public async Task CriarCompra(Compra compra)
    {
        await _compraService.CriarCompra(compra);
    }

    public async Task Delete(Compra objeto)
    {
        await _compraRepository.Delete(objeto);
    }

    public async Task<Compra> GetEntityById(int Id)
    {
       return await _compraRepository.GetEntityById(Id);
    }

    public Task<List<Compra>> List()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Compra>> ListarComprasPorData(DateTime dataCompra)
    {
        return await _compraService.ListarComprasPorData(dataCompra);
    }

    public async Task Update(Compra objeto)
    {
        await _compraRepository.Update(objeto); 
    }
}
