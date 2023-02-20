namespace Anselmex.Domain.AccountsRequests;
public class Requisicao
{
    public Nome Nome {get; private set;}
    public Email Email{get; private set;}
    public DateTime HoraDaRequisicao {get; private set;}
    public Requisicao(Nome nome, Email email)
    {
        this.Nome = nome;
        this.Email = email;
        this.HoraDaRequisicao = DateTime.Now;

        Validar();
    }

    public void Validar()
    {

    }
}