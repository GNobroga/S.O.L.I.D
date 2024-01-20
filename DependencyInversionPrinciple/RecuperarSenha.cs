namespace DependencyInversionPrinciple;

public class RecuperarSenha 
{   
    // Dessa forma essa classe depende de uma abstração e não está aclopada a uma instância específica.
    private IDatabaseConnection _connection;

    public RecuperarSenha(IDatabaseConnection connection)
    {
        _connection = connection;
    }
}