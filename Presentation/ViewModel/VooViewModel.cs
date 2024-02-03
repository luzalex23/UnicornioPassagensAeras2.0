using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Presentation.ViewModel;

public class VooViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Aeroporto de Origem é obrigatório.")]
    public long AeroportoOrigemID { get; set; }

    [Required(ErrorMessage = "O campo Aeroporto de Destino é obrigatório.")]
    public long AeroportoDestinoID { get; set; }

    [Required(ErrorMessage = "O campo Data e Hora de Partida é obrigatório.")]
    [DataType(DataType.DateTime)]
    public DateTime DataHoraPartida { get; set; }

    public AeroportoViewModel AeroportoOrigemNome { get; set; }
    public AeroportoViewModel AeroportoDestinoNome { get; set; }

    public List<Classe> Classes { get; set; } = new List<Classe>();
}
