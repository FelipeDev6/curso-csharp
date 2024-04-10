using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o endereço: ");
        string endereco = Console.ReadLine();

        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine();

        Console.WriteLine("\nDetalhes inseridos:");
        Console.WriteLine("Endereço: " + endereco);
        Console.WriteLine("Telefone: " + telefone);


        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}