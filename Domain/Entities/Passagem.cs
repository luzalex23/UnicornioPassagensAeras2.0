using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Passagem 
{
    public long PassagemID { get; set; }
    public long VooID { get; set; }
    public long ClasseID { get; set; }
    public long PassageiroID { get; set; }
    public long CompraID {  get; set; }
    public decimal PrecoTotal { get; set; }

    public Voo Voo { get; set; } = new Voo();
    public Compra Compra { get; set; } = new Compra();
    public Classe Classe { get; set; } = new Classe();
    public Passageiro Passageiro { get; set; } = new Passageiro();
}
