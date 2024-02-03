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
    public int VooId { get; set; }
    public int ClasseId { get; set; }
    public Voo Voo { get; set; }
    public Classe Classe { get; set; }
    public Passageiro Passageiro { get; set; }
}
