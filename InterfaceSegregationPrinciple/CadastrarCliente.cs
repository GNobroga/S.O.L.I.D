namespace InterfaceSegregationPrinciple;

public class CadastrarCliente : IPersistencia
{
    public void EnviarEmail(string email, string mensagem)
    {
        Console.WriteLine("Enviando...");
    }

    public void SalvarDatabase()
    {
        Console.WriteLine("Salvando");
    }

    public bool ValidarDados()
    {
        return true;
    }
}
