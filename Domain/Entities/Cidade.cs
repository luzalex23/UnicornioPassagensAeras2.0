namespace Domain.Entities;

public class Cidade : BaseDomainEntity
{
    public string UF { get; set; }
    public List<Aeroporto> Aeroportos { get; set; }

}