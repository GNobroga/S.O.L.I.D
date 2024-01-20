# Clean Code

- Nomenclatura: Adote um padrão

- Use nomes significativos

- Organize o código

- Use métodos pequenos

- Seja comedido nos comentários

- Documente somente o necessário

- Evite números mágicos

- Realize o tratamento de erros

## DRY - Do not repeat yourself

O princípio **DRY** significa não escrever código duplicado, seja uma classe, um método ou qualquer lógica.

No exemplo abaixo ao invés de duplicar a lógica da função **calcular_area_quadrilatero**, eu reaproveito a lógica dela nas outras funções.


```py
    def calcular_area_quadrilatero(base, altura):
        area = base * altura
        return area

    def calcular_area_retangulo(largura, altura):
        return calcular_area_quadrilatero(largura, altura)

    def calcular_area_quadrado(lado):
        return calcular_area_quadrilatero(lado, lado)
```

- Cada funcionalidade de um projeto deve ser representada apenas uma vez

- Facilita a manutenção e o entendimento do código

### Dica

- Se estiver repetindo um código muitas vezes o ideal é refatorar para que não se repita.

- Não tente reiventar lógica que já existe, por exemplo, funções já prontas de uma linguagem.