using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class CompraService : ICompraService
{
    private readonly ICompraRepository _compraRepository;
    public CompraService(ICompraRepository compraRepository)
    {
        _compraRepository = compraRepository;
    }
    public async Task AtualizarCompra(Compra compra)
    {
        await _compraRepository.Update(compra);
    }

    public async Task CriarCompra(Compra compra)
    {
        await _compraRepository.Add(compra);
    }

    public async Task<List<Compra>> ListarComprasPorData(DateTime dataCompra)
    {
        return await _compraRepository.ListarComprasPorData(dataCompra);
    }
}
