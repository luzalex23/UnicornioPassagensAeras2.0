using Domain.Entities;


namespace Domain.Services.InterfacesServicos;

public interface IPassagemService : IServiceGeneric<Passagem>
{
    Task CriarPassagem(Passagem passagem);
    Task AtualizarPassagem(Passagem passagem);


}
