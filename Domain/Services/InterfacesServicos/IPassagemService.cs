using Domain.Entities;


namespace Domain.Services.InterfacesServicos;

public interface IPassagemService
{
    Task CriarPassagem(Passagem passagem);
    Task AtualizarPassagem(Passagem passagem);


}
