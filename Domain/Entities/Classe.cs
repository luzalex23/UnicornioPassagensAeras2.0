using Domain.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Classe
{
    public int Id { get; set; }
    public TipoClasse TipoClasse { get; set; }
    public int QuantidadeAssentos { get; set; }
    public decimal ValorAssento { get; set; }
    public int VooID { get; set; }

    public Voo Voo { get; set; } = new Voo();
}
