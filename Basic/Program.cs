// See https://aka.ms/new-console-template for more information

enum NivelDeAcesso
{
    Basico = 1,
    Intermediario = 2,
    Avancado = 3
}

class Program
{
    static void Main()
    {
        NivelDeAcesso acesso = NivelDeAcesso.Intermediario;

        Console.WriteLine(acesso);                    // Saída: Intermediario
        Console.WriteLine((int)acesso);               // Saída: 2
        Console.WriteLine(Enum.GetName(typeof(NivelDeAcesso), 3)); // Saída: Avancado

        foreach (var nivel in Enum.GetValues(typeof(NivelDeAcesso)))
        {
            Console.WriteLine($"{(int)nivel} - {nivel}");
        }
    }
}