namespace DependencyInversionPrinciple;

public class MySQLConnection : IDatabaseConnection
{
    public void Conectar()
    {
        Console.WriteLine("Username=root;Password=root;Database=root;Host=localhost;Port=3324");
    }
}