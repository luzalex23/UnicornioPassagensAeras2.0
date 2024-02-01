using Domain.Entities;
using Domain.Repositories;
using Domain.Services.InterfacesServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class ReservaService : IReservaService
{
    private readonly IRepository<Reserva> _reservaRepository;
    public ReservaService(IRepository<Reserva> reservaRepository)
    {
        _reservaRepository = reservaRepository;
    }

    public async Task AtualizarReserva(Reserva reserva)
    {
        await _reservaRepository.Update(reserva);
    }

    public async Task CriarReserva(Reserva reserva)
    {
        await _reservaRepository.Add(reserva);
    }
}
