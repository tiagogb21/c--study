// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("------------------------------------------");

// Programa 1: Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

Console.Write("Digite seu nome: ");

var name = Console.ReadLine();

Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");

Console.WriteLine("------------------------------------------");

// Programa 2: Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

Console.Write("Digite seu primeiro nome: ");
var firstName = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
var lastName = Console.ReadLine();

Console.WriteLine($"{firstName} {lastName}");

Console.WriteLine("------------------------------------------");

// Programa 3:

// 1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
//     - A soma entre esses dois números;
//     - A subtração entre os dois números;
//     - A multiplicação entre os dois números;
//     - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
//     - A média entre os dois números.

Console.Write("Digite o primeiro número: ");
var num1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
var num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Soma: {num1} + {num2} = {num1 + num2}");
Console.WriteLine($"Subtração: {num1} - {num2} = {num1 - num2}");
Console.WriteLine($"Multiplicação: {num1} * {num2} = {num1 * num2}");
Console.WriteLine($"Divisão: {num1} / {num2} = {num1 / num2}");
Console.WriteLine($"Média: ({num1} + {num2})/2 = {(num1 + num2)/2}");
