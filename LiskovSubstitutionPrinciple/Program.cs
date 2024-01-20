
using LiskovSubstitutionPrinciple.example_1;

Funcionario funcionario = new Vendedor();

funcionario.Atender(); // Aqui eu violo o princípio LSP porque a classe base não manteve sua funcionalidade.

// Pra não violar o princípio o funcionário deveria ter um método semelhante e que mantenha a mesma lógica.