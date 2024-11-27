# Enum

Enum ==> Enumeration

Tipo de valor usado para definir um conjunto de constantes nomeadas, tornando o código mais legível e fácil de manter.


Enum.GetNames(typeof(T))	   --> Retorna todos os nomes do enum.
Enum.GetValues(typeof(T))	   --> Retorna todos os valores do enum.
Enum.IsDefined(typeof(T), x) --> Verifica se x é válido no enum.
ToString()	                 --> Converte o valor do enum em string.
(T)Enum.Parse(typeof(T), x)	 --> Converte uma string em valor do enum.


## Valores implícitos

```c#
  enum NivelDeDificuldade {
    Baixo,
    Medio,
    Alto
  }

  NivelDeDificuldade nivel = NivelDeDificuldade.Baixo;
  NivelDeDificuldade nivel = NivelDeDificuldade.Medio;
  NivelDeDificuldade nivel = NivelDeDificuldade.Alto;
```

## Valores explícitos

```c#
  enum StatusPedido
  {
      Pendente = 1,
      EmProcessamento = 2,
      Concluido = 3,
      Cancelado = 4
  }
```

### I - Regras para construir valores explícitos:

1. Número NÃO precisam ser em sequência
2. Números precisam ser positivos
3. NÃO pode ter números duplicados

### II - Como usar:

1. Atribuindo um valor:

```c#
  StatusPedido status = StatusPedido.EmProcessamento;
```

2. Obtendo o valor numérico
```c#
  int valor = (int)StatusPedido.Concluido; // Resultado: 3
```

3. Convertendo de inteiro para enum
```c#
  StatusPedido status = (StatusPedido)3; // Resultado: StatusPedido.Concluido
```

### 3 - Iteração

```c#
  foreach (var nome in Enum.GetNames(typeof(DiasDaSemana)))
  {
      Console.WriteLine(nome); // Lista: Domingo, Segunda, ...
  }

  foreach (var valor in Enum.GetValues(typeof(DiasDaSemana)))
  {
      Console.WriteLine((int)valor); // Lista: 0, 1, 2, ...
  }
```

### 4 - Checando valores

```c#
  if (Enum.IsDefined(typeof(DiasDaSemana), "Segunda"))
  {
      Console.WriteLine("Segunda é um dia válido.");
  }

  if (Enum.IsDefined(typeof(StatusPedido), 3))
  {
      Console.WriteLine("3 é um StatusPedido válido.");
  }
```

## Flags:

Declarando um enum com [Flags]:

```c#
  [Flags]
  enum Permissoes
  {
      Nenhuma = 0,
      Ler = 1,
      Escrever = 2,
      Executar = 4,
      Tudo = Ler | Escrever | Executar
  }
```

##Usando combinações:

```c#
  Permissoes permissao = Permissoes.Ler | Permissoes.Escrever;

  // Checando se contém uma permissão específica
  bool podeEscrever = permissao.HasFlag(Permissoes.Escrever); // true

  // Adicionando uma permissão
  permissao |= Permissoes.Executar; // Resultado: Tudo

  // Removendo uma permissão
  permissao &= ~Permissoes.Ler; // Remove "Ler"
```