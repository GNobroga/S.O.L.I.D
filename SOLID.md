# S.O.L.I.D

## SRP - Single Reponsability Principle

Cada classe deve ter apenas uma responsabilidade a ser cumprida.

### OCP - Open/Closed Principle

- Você deve ser capaz de estender um comportamento de uma classe sem a necessidade de alterá-la. Classes deverão ser abertas para extensão mas fechadas para alteração.

**Estender** significa incluir novas funcionalidades sem precisar 'mexer' no que está pronto, matendo a estabilidade do código.

## LSP - Liskov Substitution Principle

- Uma classe base deve poder ser substituída pela sua classe derivada sem alteração no comportamento final. Ou seja, uma classe derivada deve poder sobrescrever os métodos da classe base de forma que a funcionalidade do ponto de vista do cliente continua mesma (sem quebrar o código). Esse princípio é aplicável quando existe um relacionamento de herança onde temos uma ou mais classes derivadas herdando de uma classe base.

### Como um método em uma classe derivada pode quebrar o contrato de um método da classe base?

1. Retornar um objeto incompatível com o objeto retornado pelo método da classe base.

2. Lançar uma nova exceção que não é lançada pelo método da classe base.

3. Alterar a semântica ou introduzir efeitos colaterais que não fazem parte do contrato da classe base.

## ISP - Interface Segregation Principle

- Muitas interfaces específicas são melhores do que uma interface geral. Ou seja, uma interface não deve forçar uma classe a implementar funcionalidades que ela não irá utilizar.

## DIP - Dependency Inversion Principle

- Dependa de abstrações e não de implementações. (Abstrações podem ser entendidas como interfaces ou classes abstratas)

## Benefícios

- Única responsabilidade
- Classes menores
- Fáceis de manter
- Mais fáceis de estender
- Fáceis de testar