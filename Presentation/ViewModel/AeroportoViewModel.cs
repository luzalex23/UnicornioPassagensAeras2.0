using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Presentation.ViewModel;

public class AeroportoViewModel
{
    public long Id { get; set; }

    [Required(ErrorMessage = "O campo Código IATA é obrigatório.")]
    public string CodigoIATA { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
    public string NomeCidade { get; set; }
}
