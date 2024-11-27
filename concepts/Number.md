# Formatos Literais

## Inteiros:

```c#
  int binario = 0b1010;    // Binário
  int hexadecimal = 0xFF;  // Hexadecimal
  int decimal = 42;        // Decimal
```

## Ponto Decimal

```c#
  float valorFloat = 3.14f;
  double valorDouble = 2.71828;
  decimal valorDecimal = 1.5m;
```

## Conversão (cast):

Explicita:

```c#
  int x = (int)3.14; // Trunca o valor: x = 3
```

Usando métodos:

```c#
  string texto = "123";
  int numero = int.Parse(texto); // Exceção se falhar
  bool sucesso = int.TryParse(texto, out int resultado); // Seguro
```

Usando Convert:

```c#
  string texto = "123";
  int numero = Convert.ToInt32(texto);  // Converte string para int
  double numeroDouble = Convert.ToDouble("45.67");
```

## Funções de Biblioteca

Math:

```c#
  double raiz = Math.Sqrt(16);  // 4
  double potencia = Math.Pow(2, 3); // 8
  double abs = Math.Abs(-10);  // 10
  double round = Math.Round(3.14159, 2); // 3.14
```

Gerar Números Aleatórios:

```c#
  Random rand = new Random();
  int aleatorio = rand.Next(1, 10); // Entre 1 e 9
  double aleatorioDouble = rand.NextDouble(); // Entre 0.0 e 1.0
```

## Constantes:

```c#
  const double PI = 3.14159;
  const int MAX_VALOR = 1000;
```

## Formatação de Strings:

```c#
  int valor = 123;
  string texto = valor.ToString();  // "123"
  string formatado = valor.ToString("C");  // "R$123,00" (em PT-BR)
```
