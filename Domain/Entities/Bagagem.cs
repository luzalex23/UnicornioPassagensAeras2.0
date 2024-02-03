using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Domain.Entities;

public class Bagagem
{
   
    public long BagagemID { get; set; }
    public Passagem Passagem { get; set; } = new Passagem();
    public long PassagemID { get; set; }
    public Bagagem(long BagagemID, Passagem passagem)
    {
        this.BagagemID = BagagemID;
        Passagem = passagem;
    }
    public Bagagem()
    {
    }

}
