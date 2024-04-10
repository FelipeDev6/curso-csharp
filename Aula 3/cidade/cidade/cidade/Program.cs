using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a cidade onde você nasceu: ");
        string cidadeNascimento = Console.ReadLine();

        Console.Write("Digite o ano em que você nasceu: ");
        int anoNascimento = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nNome: " + nome);
        Console.WriteLine("Cidade de nascimento: " + cidadeNascimento);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
