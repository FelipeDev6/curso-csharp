using System;

class Program
{
    static void Main(string[] args)
    {
        double saldo = 20.0;

        Console.Write("Digite o preço do biscoito: ");
        double precoBiscoito = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o preço do refrigerante: ");
        double precoRefrigerante = Convert.ToDouble(Console.ReadLine());

        double totalGasto = precoBiscoito + precoRefrigerante;

        double troco = saldo - totalGasto;

        if (troco >= 0)
        {
            Console.WriteLine("\nVocê tem R$" + troco.ToString("0.00") + " de troco.");
        }
        else
        {
            Console.WriteLine("\nVocê não tem dinheiro suficiente para comprar esses itens.");
        }
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
