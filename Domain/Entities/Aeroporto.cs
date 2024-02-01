namespace Domain.Entities;

public class Aeroporto : BaseDomainEntity
{
    public Iata Iata { get; set; } = new Iata();
    public long IataID { get; set; }
    public string CodigoIATA { get; set; } = string.Empty;
    public long CidadeID { get; set; }
    public Cidade Cidade { get; set; } = new Cidade();


}
