using System.Text.RegularExpressions;
namespace Anselmex.Domain.AccountsRequests;
public struct Email
{
    string email;
    string username;
    string dominioDoEmail;
    public Email(string email)
    {
        this.email = email;

        string[] splitted_email = email.Split('@');
        username = splitted_email[0];
        dominioDoEmail = splitted_email[1];

        Validar();
    }

    private void Validar()
    {
        if(!Regex.IsMatch(this.email, @"\w"))
            throw new InvalidOperationException("E-mail incorreto");

        if(!Regex.IsMatch(this.username, @"\w"))
            throw new InvalidOperationException("Username do e-mail incorreto");

        if(!Regex.IsMatch(this.dominioDoEmail, @"\w"))
            throw new InvalidOperationException("dominio do e-mail incorreto");                        
    }
}