<h1> Código exemplo 04 </h1>

```csharp
    using System;

    namespace Project04
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n1Value = 500;
                int n2Value = 600;
                int largeValue;

                largeValue = Math.Max(n1Value, n2Value);
                Console.WriteLine($"O maior valor entre {n1Value} e {n2Value} é: {largeValue}");
            }
        }
    }
 ```

<h2><b><i> Analise: </i></b></h2>

- Invocamos nossa diretiva <u><b>using System.</b></u>
- Criamos namespace chamado Project04 que tem como finalidade organizar de forma logica as classes que podemos criar.
- Criamos uma class chamada Program.
- Criamos o metodo principal do programa chamada Main.
- Declaramos 3 variaveis de tipo integer, sendo que 2 foram devidamente inicializadas e uma não.

<h2> Mas o que há de diferente nesse código ?</h2>

```csharp
    largeValue = Math.Max(n1Value, n2Value);
    Console.WriteLine($"O maior valor entre {n1Value} e {n2Value} é: {largeValue}");
```

- acima observa-se que a variavel <u><b>largeValue</b></u> recebe a classe <u><b>Math</b></u> com seu metodo <u><b>Max</b></u> com 2 parametros, esses paramentros são os valores que foram inicializadas cada variavel. Mas o que examente ocorre ? com os parametros a classe Math juntamente com seu metodo Max() estabelece uma comparação entre o conteudo da variavel <u><b>n1Value</b></u> e <u><b>n2Value</b></u> para averiguar qual dos 2 possui o valor maior. Isso é interessante porque dispensa, por exemplo, não utilizar o <b>if</b>.

[Sobre a classe Math.Max()](https://learn.microsoft.com/en-us/dotnet/api/system.math.max?view=net-8.0#definition)


<h2><b> Conclusão: </b></h2>

- Embora seja um programa bem simples, ele mostra que na simplicidade há soluções mais sofiticadas do que outros recursos comumente usados, fora o fato que mostra como o codigo c# é um código elegante e conciso, ainda mais que utilizamos nele o recurso de interpolação de variaveis que deixa ele muito mais agradável.