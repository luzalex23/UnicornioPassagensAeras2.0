using Domain.Entities;


namespace Domain.Services.InterfacesServicos;

public interface ICompraService
{
    Task CriarCompra(Compra compra);
    Task AtualizarCompra(Compra compra);  
    Task<List<Compra>> ListarComprasPorData(DateTime dataCompra);


}
