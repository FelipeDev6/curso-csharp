using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        double media = (numero1 + numero2) / 2;

        Console.WriteLine("A média aritmética entre " + numero1 + " e " + numero2 + " é: " + media);
        Console.Read();
    }
}
