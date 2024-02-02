namespace Domain.Entities;

public class Passageiro : BaseDomainEntity
{
    public DateTime Dtnascimento { get; private set; }
    public int idade {  get; private set; }
    public string Cpf { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;

    public int Idade(int idade)
    {
        int anotual = DateTime.Now.Year;
        int anoNas = Dtnascimento.Year;
        this.idade = anotual - anoNas;
        return idade;
    }
}