# Array

Estrutura fixa de tamanho e tipos

## Declarando

```c#
// Declarando
int[] numeros = new int[5];

// Inicializando diretamente
int[] numeros = [ 1, 2, 3, 4, 5 ];

// Acessar elementos
int primeiro = numeros[0];
numeros[1] = 10;

// Iterar
foreach (int numero in numeros)
    Console.WriteLine(numero);
```

## Métodos e Propriedades

1. Length: Retorna o tamanho do array.

```c#
  Console.WriteLine(numeros.Length); // 5
```

2. Ordenar

```c#
  Array.Sort(numeros); // Ordena em ordem crescente
```

3. Reverter

```c#
  Array.Reverse(numeros); // Inverte a ordem
```

4. CopyTo(array, index): Copia os elementos para outro array, começando no índice especificado.

```c#
int[] origem = { 1, 2, 3 };
int[] destino = new int[5];
origem.CopyTo(destino, 1); // Copia a partir do índice 1 no destino
```

5. Clone: Cria uma cópia superficial do array.

```c#
  int[] numeros = { 1, 2, 3 };
  int[] copia = (int[])numeros.Clone();
```

6. Array.Fill(array, value): Preenche todos os elementos do array com um valor específico.

```c#
  int[] numeros = new int[5];
  Array.Fill(numeros, 42); // Preenche o array com o valor 42
  Console.WriteLine(string.Join(", ", numeros)); // 42, 42, 42, 42, 42
```

7. Array.Find(array, match): Retorna o primeiro elemento que atende a uma condição.

```c#
  int[] numeros = { 1, 2, 3, 4, 5 };
  int resultado = Array.Find(numeros, n => n > 3);
  Console.WriteLine(resultado); // 4
```

8. Array.FindIndex(array, match): Retorna o índice do primeiro elemento que atende a uma condição.

```c#
  int[] numeros = { 1, 2, 3, 4, 5 };
  int index = Array.FindIndex(numeros, n => n > 3);
  Console.WriteLine(index); // 3
```

9.  Array.FindAll(array, match): Retorna todos os elementos que atendem a uma condição.

```c#
  int[] numeros = { 1, 2, 3, 4, 5 };
  int[] resultado = Array.FindAll(numeros, n => n > 3);
  Console.WriteLine(string.Join(", ", resultado)); // 4, 5
```

10.  Array.FindLast(array, match): Retorna o último elemento que atende a uma condição.

```c#
  int[] numeros = { 1, 2, 3, 4, 5 };
  int resultado = Array.FindLast(numeros, n => n > 3);
  Console.WriteLine(resultado); // 5
```

11. Array.FindLastIndex(array, match): Retorna o índice do último elemento que atende a uma condição.

```c#
  int[] numeros = { 1, 2, 3, 4, 5 };
  int index = Array.FindLastIndex(numeros, n => n > 3);
  Console.WriteLine(index); // 4
```

12. Array.ForEach(array, action): Executa uma ação para cada elemento do array.

```c#
  int[] numeros = { 1, 2, 3, 4, 5 };
  Array.ForEach(numeros, n => Console.WriteLine(n * 2)); // 2, 4, 6, 8, 10
```

13. IndexOf(array, value): Retorna o índice do primeiro elemento correspondente ao valor.

```c#
  int[] numeros = { 1, 2, 3 };
  Console.WriteLine(Array.IndexOf(numeros, 2)); // 1
```

14. LastIndexOf(array, value): Retorna o índice da última ocorrência do valor.

```c#
  int[] numeros = { 1, 2, 3, 2 };
  Console.WriteLine(Array.LastIndexOf(numeros, 2)); // 3
```

15. Array.Resize(ref array, newSize): Redimensiona o array (preserva os valores existentes, se possível).

```c#
  int[] numeros = { 1, 2, 3 };
  Array.Resize(ref numeros, 5); // Redimensiona para 5 posições
  Console.WriteLine(string.Join(", ", numeros)); // 1, 2, 3, 0, 0
```

16. Array.Reverse(array): Inverte a ordem dos elementos no array.

```c#
  int[] numeros = { 1, 2, 3 };
  Array.Reverse(numeros);
  Console.WriteLine(string.Join(", ", numeros)); // 3, 2, 1
```

17. Array.ToString(): Retorna o tipo do array (não os elementos). Para exibir os elementos, use string.Join

int[] numeros = { 1, 2, 3 };
Console.WriteLine(numeros.ToString()); // System.Int32[]
Console.WriteLine(string.Join(", ", numeros)); // 1, 2, 3

18. GetLength(dimension): Retorna o comprimento de uma dimensão específica de arrays multidimensionais.

```c#
int[,] matriz = new int[3, 4];
  Console.WriteLine(matriz.GetLength(0)); // 3 (1ª dimensão)
  Console.WriteLine(matriz.GetLength(1)); // 4 (2ª dimensão)
```

19. GetValue(index) / SetValue(value, index): Obtém ou define o valor de um elemento em um índice específico.

```c#
int[] numeros = { 1, 2, 3 };
Console.WriteLine(numeros.GetValue(1)); // 2
numeros.SetValue(10, 1);
Console.WriteLine(numeros[1]); // 10
```





