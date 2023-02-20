using System.Text.RegularExpressions;

namespace Anselmex.Domain.AccountsRequests;
public struct Nome
{
    string PrimeiroNome;
    string NomeDoMeio;
    string UltimoNome;
    public Nome(string primeiroNome, string nomeDoMeio, string ultimoNome)
    {
        this.PrimeiroNome = primeiroNome;
        this.NomeDoMeio = nomeDoMeio;
        this.UltimoNome = ultimoNome;

        Validar();
    }

    private void Validar()
    {
        if(!Regex.IsMatch(this.PrimeiroNome, @"\w"))
            throw new InvalidOperationException("Primeiro nome incorreto");

        if(!Regex.IsMatch(this.NomeDoMeio, @"\w"))
            throw new InvalidOperationException("Nome do meio incorreto");

        if(!Regex.IsMatch(this.UltimoNome, @"\w"))
            throw new InvalidOperationException("Último nome incorreto");                        
    }
}