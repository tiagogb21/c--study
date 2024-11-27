## Comparação

Array	                |     Lista (List<T>)
Tamanho fixo	        |     Tamanho dinâmico
Usa menos memória	    |     Mais flexível
Manipulação direta	  |     Métodos prontos e convenientes

## Conversão

```c#
  int[] array = { 1, 2, 3 };
  List<int> lista = new List<int>(array); // Converter array em lista
  lista.Add(4);
  int[] novoArray = lista.ToArray(); // Converter lista em array
```
