# Null

Representa a ausência de valor ou referência em tipos que podem aceitar valores nulos

Tipos de Referência     --> string, object, ...

Tipos de Valor Nullable --> int?, object?, ...

type? --> "?" indica que o valor é do tipo nullable

ex.: se tiver um campo opcional no banco de dados

```c#
  int? idade = null
```

## Declarando e Utilizando

```c#
  string name = null;

  if(name == null) {
    Console.WriteLine("O valor é nulo.");
  }
```

## Tipos de valor nullable

```c#
  int? idade = null;
  if (!idade.HasValue)
  {
      Console.WriteLine("Idade não foi informada.");
  }
```

## Propriedades de tipos nullable

HasValue -->	Retorna true se o valor não for null.
Value    -->	Retorna o valor armazenado ou lança uma exceção se for null.

```c#
  int? numero = 42;
  if (numero.HasValue)
  {
      Console.WriteLine(numero.Value); // Saída: 42
  }
```

## Operador de coalescência nula (??)

Usado para fornecer um valor padrão se a variável for null.

```c#
  string nome = null;
  Console.WriteLine(nome ?? "Valor padrão"); // Saída: Valor padrão

  int? numero = null;
  Console.WriteLine(numero ?? 0); // Saída: 0
```

## Operador de atribuição de coalescência nula (??=)

Atribui um valor apenas se a variável for null.

```c#
  string nome = null;
  nome ??= "Nome padrão";
  Console.WriteLine(nome); // Saída: Nome padrão
```

## Operador de acesso condicional (?.)

Evita exceções ao acessar membros de objetos nulos.

```c#
string nome = null;
Console.WriteLine(nome?.Length); // Saída: (nenhuma, valor nulo)

Pessoa pessoa = null;
Console.WriteLine(pessoa?.Endereco?.Cidade); // Seguro mesmo se `pessoa` for null
```

## Verificação de nulidade com is null

Uma maneira moderna de verificar valores nulos:

```c#
if (nome is null)
{
    Console.WriteLine("O valor é nulo.");
}
```
