using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o preço do refrigerante: ");
        double precoRefrigerante = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o preço do sanduíche: ");
        double precoSanduiche = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nPreço do refrigerante: R$" + precoRefrigerante);
        Console.WriteLine("Preço do sanduíche: R$" + precoSanduiche);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
