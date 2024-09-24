// See https://aka.ms/new-console-template for more information

using System;

// O char é utilizado para armazenar apenas um caractere.
// A string é utilizada para armazenar frases ou textos completos

String name = "tiago";
Console.WriteLine("Tamanho do nome" + name.Length);

// Para verificar se uma string começa com um determinado caractere
Console.WriteLine(name.StartsWith("ti"));
// Para verificar se uma string termina com um determinado caractere
Console.WriteLine(name.StartsWith("go"));
// Contains --> verifica se uma substring existe em uma string
Console.WriteLine(name.Contains("ti")); // True

// Equals --> verifica se uma string é igual a outra
Console.WriteLine(name.Equals("tiago")); // True

String nameWithSpace = "  tiago   ";
Console.WriteLine(nameWithSpace.Length); // 10
String nameWithoutSpace = nameWithSpace.Trim();
Console.WriteLine(nameWithoutSpace.Length); // 5

// Letra maiúscula
Console.WriteLine("Nome em maiúscula: " + name.ToUpper());
// Letra minúscula
Console.WriteLine("Nome em minúscula: " + name.ToLower());

// Concatenando strings
String firstName = "tiago";
String lastName = "garbi";
String fullName = firstName + " " + lastName;
Console.WriteLine(fullName);
// Concatenando com Concat
Console.WriteLine(string.Concat(firstName, lastName));
// Concatenando números no formato de string
string number1 = "10";
string number2 = "20";
Console.WriteLine(number1 + number2); // "1020"
int number10 = 10;
string word = "20";
Console.WriteLine(number10 + word); // "1020"

// Interpolação de string
string city = "Ouro Fino";
string state = "MG";
Console.WriteLine($"Minha cidade {city}, fica no estado de: {state}");

// Acessando um caracter de uma string
string message = "Hello, world!";
char firstChar = message[0];
Console.WriteLine(firstChar); // H
char secondChar = message[1];
Console.WriteLine(secondChar); // e
char lastChar = message[message.Length - 1];
Console.WriteLine(lastChar); // !

// IndexOf --> permite procurar por um caracter específico
Console.WriteLine(message.IndexOf("w")); // 7
int charPos = fullName.IndexOf("ga");

// Replace --> permite trocar uma substring por outra, troca todas as substrings encontradas
string original = "Hello, world!";
string modified = original.Replace("world", "earth");
Console.WriteLine(modified);

// Substring --> permite dividir uma string em partes menores
string lastNameFromFullName = fullName.Substring(charPos);
Console.WriteLine(lastNameFromFullName);
