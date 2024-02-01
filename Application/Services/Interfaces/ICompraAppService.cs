using Domain.Entities;
using System;

namespace Application.Services.Interfaces;

public interface ICompraAppService : IGenericAppService<Compra>
{
    Task CriarCompra(Compra compra);
    Task AtualizarCompra(Compra compra);
    Task <List<Compra>> ListarComprasPorData(DateTime dataCompra);
}
