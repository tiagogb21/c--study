# Estrutura

Uma instrução deve estar dentro de uma função que por sua vez está dentro de uma classe, uma classe está dentro de um namespace.

## Namespace

Referência/Endereçamento

É uma forma de organizar as classes e interfaces dentro de um projeto.

Permite evitar conflitos de nomes e facilita o endereçamento das classes.

``` c#
    // versão mais antiga
    namespace NomeDoProjeto {
        public class Classe {
            // código
        }
    }
```

``` c#
    // versão mais nova
    namespace NomeDoProjeto;
```










