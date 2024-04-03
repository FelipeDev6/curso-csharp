using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int resultado = numero1 * numero2;

        Console.WriteLine($"O resultado dessa multiplicação é: " + resultado);
        Console.ReadKey();
    }
}
