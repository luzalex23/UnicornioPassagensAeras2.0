using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Compra
{
    public long CompraID { get; set; }
    public long PassageiroID { get; set; }
    public long VooID { get; set; }
    public long ClasseID { get; set; }
    public int QuantidadePassagens { get; set; }
    public Passageiro Passageiro { get; set; } = new Passageiro();
    public Voo Voo { get; set; } = new Voo();
    public Classe Classe { get; set; } = new Classe();
}

