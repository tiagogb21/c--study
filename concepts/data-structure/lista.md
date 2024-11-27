# Lista

Estrutura dinâmica e genérica (List<T>)

## Declarar

```c#
  // Declarando
  List<int> numeros = new List<int>();

  // Adicionar elementos
  numeros.Add(1);
  numeros.Add(2);

  // Inicializando diretamente
  List<int> numeros = new List<int> { 1, 2, 3, 4 };

  // Acessar elementos
  int primeiro = numeros[0];
  numeros[1] = 10;

  // Remover elementos
  numeros.Remove(10); // Remove o valor
  numeros.RemoveAt(0); // Remove pelo índice
```

## Métodos

1. Count: Retorna o número de elementos.

```c#
  Console.WriteLine(numeros.Count);
```

2. AddRange: Adicionar múltiplos elementos:

```c#
  numeros.AddRange(new List<int> { 5, 6, 7 });
```

3. Contains: Verifica existência

```c#
  Console.WriteLine(numeros.Contains(5)); // true
```

4. Clear: Limpa a lista:

```c#
  numeros.Clear();
```

Alguns exemplos de método utilizados em arrays também estão disponíveis para listas (List<T>), como: Find, FindIndex, FindLast, FindLastIndex.

```c#
  List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

  // Encontrar
  Console.WriteLine(numeros.Find(n => n > 3)); // 4
  Console.WriteLine(numeros.FindLast(n => n > 3)); // 5

  // Índices
  Console.WriteLine(numeros.FindIndex(n => n > 3)); // 3
  Console.WriteLine(numeros.FindLastIndex(n => n > 3)); // 4

  // Todos
  List<int> maioresQueTres = numeros.FindAll(n => n > 3);
  Console.WriteLine(string.Join(", ", maioresQueTres)); // 4, 5
```
