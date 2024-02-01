using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Reserva
{
    public long ReservaID { get; set; }
    public long PassageiroId { get; set; }
    public long VooId { get; set; }
    public long ClasseId { get; set; }
}
