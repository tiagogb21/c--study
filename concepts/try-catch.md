# try catch

```c#
  try
  {
      int numero = int.Parse("texto inválido"); // Gera uma exceção
  }
  catch (FormatException)
  {
      Console.WriteLine("Erro: Formato inválido.");
  }
```
