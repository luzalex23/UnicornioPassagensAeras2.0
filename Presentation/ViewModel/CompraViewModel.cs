using Domain.Entities;

namespace Presentation.ViewModel;

public class CompraViewModel
{
    public long CompraID { get; set; }
    public DateTime CompraDate { get; set; }
    public long PassageiroID { get; set; }
    public long VooID { get; set; }
    public long ClasseID { get; set; }
    public int QuantidadePassagens { get; set; }
    public Passageiro Passageiros { get; set; } = new Passageiro();
    public Voo Voos { get; set; } = new Voo();
    public Classe Classes { get; set; } = new Classe();
}

