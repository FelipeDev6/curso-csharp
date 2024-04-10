using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {            
            Console.WriteLine("Você digitou o número: " + number);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
            Console.ReadKey();
        }
    }
}
