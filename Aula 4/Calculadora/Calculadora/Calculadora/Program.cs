using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int soma = num1 + num2;

        if (soma > 10)
        {
            Console.WriteLine("A soma é maior que 10 e seu valor é: " + soma);
        }

        Console.ReadLine();
        Console.ReadKey();
    }
}
