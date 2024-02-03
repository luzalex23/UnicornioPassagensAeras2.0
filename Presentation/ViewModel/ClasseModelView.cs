using Domain.Entities.Enuns;
using Domain.Entities;

namespace Presentation.ViewModel;

public class ClasseModelView
{
    public int Id { get; set; }
    public TipoClasse TipoClasse { get; set; }
    public int QuantidadeAssentos { get; set; }
    public decimal ValorAssento { get; set; }
    public int VooID { get; set; }
}
