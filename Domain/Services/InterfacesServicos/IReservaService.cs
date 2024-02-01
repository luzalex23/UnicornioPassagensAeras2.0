using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.InterfacesServicos;

public interface IReservaService
{
    Task CriarReserva(Reserva reserva);
    Task AtualizarReserva(Reserva reserva);
}
