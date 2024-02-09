namespace Domain.Entities;

public class Aeroporto : BaseDomainEntity
{

    public long IataID { get; set; }
    public long CidadeID { get; set; }
    public Cidade Cidade { get; set; }
    public Iata Iata { get; set; } 



}
