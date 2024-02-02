using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Voo
{
    public int VooID { get; set; }
    public long AeroportoOrigemID { get; set; }
    public long AeroportoDestinoID { get; set; }
    public DateTime DataHoraPartida { get; set; }

    public Aeroporto AeroportoOrigem { get; set; } = new Aeroporto();
    public Aeroporto AeroportoDestino { get; set; } = new Aeroporto();
    public virtual List<Classe> Classes { get; set; } = new List<Classe>();
    public decimal? PrecoTotal { get; set; }
}
