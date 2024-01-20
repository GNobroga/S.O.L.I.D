namespace LiskovSubstitutionPrinciple.example_1;

public class Vendedor : Funcionario
{
    public void Atender()
    {
        Console.WriteLine("Olá, meu caro amigo!");
    }
}