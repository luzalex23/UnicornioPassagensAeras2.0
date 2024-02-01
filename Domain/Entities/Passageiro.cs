namespace Domain.Entities;

public class Passageiro : BaseDomainEntity
{
    public DateTime Dtnascimento { get; private set; }
    public string Cpf { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
}