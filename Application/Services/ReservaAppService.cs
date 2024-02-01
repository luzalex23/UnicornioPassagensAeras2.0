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

public class ReservaAppService : IReservaAppService
{
    private readonly IReservaService _reservaService;
    private readonly IRepository<Reserva> _repository;

    public ReservaAppService(IReservaService reservaService, IRepository<Reserva> repository)
    {
        _reservaService = reservaService;
        _repository = repository;
    }

    public async Task Add(Reserva objeto)
    {
      await  _repository.Add(objeto);
    }

    public async Task CriarReserva(Reserva reserva)
    {
        await _reservaService.CriarReserva(reserva);
    }

    public async Task Delete(Reserva objeto)
    {
       await _repository.Delete(objeto);
    }

    public async Task<Reserva> GetEntityById(int Id)
    {
        return await _repository.GetEntityById(Id);
    }

    public async Task<List<Reserva>> List()
    {
        return await _repository.List();
    }

    public Task<List<Reserva>> ListarReservas(Reserva reserva)
    {
        throw new NotImplementedException();
    }

    public Task Update(Reserva objeto)
    {
        throw new NotImplementedException();
    }
}
