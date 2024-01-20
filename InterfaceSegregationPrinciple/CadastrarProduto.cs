namespace InterfaceSegregationPrinciple;

// Essa classe viola o princípio ISP porque o CadastrarProduto não precisa de todos os métodos da interface e está sendo forçada a implementar.
// Pra solucionar o problema é necessário criar interfaces separadas pra cada funcionalidade.
// Criar uma interface para Enviar email e outro para Persistir
public class CadastrarProduto : IPersistencia
{

    public void EnviarEmail(string email, string mensagem)
    {
        throw new NotImplementedException("Não funcionada para cadastrar pedido");
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
