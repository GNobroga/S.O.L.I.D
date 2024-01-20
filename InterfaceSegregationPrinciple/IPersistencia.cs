namespace InterfaceSegregationPrinciple;

public interface IPersistencia 
{
    void EnviarEmail(string email, string mensagem);

    void SalvarDatabase();

    bool ValidarDados();
}
