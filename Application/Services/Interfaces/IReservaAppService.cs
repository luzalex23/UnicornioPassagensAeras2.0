using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IReservaAppService : IGenericAppService<Reserva>
{
    Task CriarReserva(Reserva reserva);
    Task<List<Reserva>> ListarReservas(Reserva reserva);

}
