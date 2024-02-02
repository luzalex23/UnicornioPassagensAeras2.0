using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Bagagem
{
    public long BagagemID { get; set; }
    public Passagem Passagem { get; set; } = new Passagem();
    public long PassagemID { get; set; }

}
