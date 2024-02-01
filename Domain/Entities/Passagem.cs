using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Passagem 
{
    public int PassagemID { get; set; }
    public int VooID { get; set; }
    public int ClasseID { get; set; }
    public int PassageiroID { get; set; }
    public decimal PrecoTotal { get; set; }

    public Voo Voo { get; set; } = new Voo();
    public Classe Classe { get; set; } = new Classe();
    public Passageiro Passageiro { get; set; } = new Passageiro();
}
