namespace Domain.Entities;

public class Cidade : BaseDomainEntity
{
    public string UF { get; set; } = string.Empty;
    public List<Aeroporto> Aeroportos { get; set; } = new List<Aeroporto>();    

}