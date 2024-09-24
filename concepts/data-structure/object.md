using System;

var dicionario = new Dictionary<string, string>();

dicionario.Add("nome1", "tiago");
dicionario.Add("nome2", "claudia");
dicionario.Add("nome3", "andrea");

foreach(var item in dicionario) {
    Console.WriteLine("Usuário: ");
    Console.WriteLine(item);
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
    Console.WriteLine("----------");
}