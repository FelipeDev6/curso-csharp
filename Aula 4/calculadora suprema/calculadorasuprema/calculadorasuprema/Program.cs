using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor:");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a operação desejada:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        int operacao = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        if (operacao == 1)
        {
            resultado = valor1 + valor2;
        }
        else if (operacao == 2)
        {
            resultado = valor1 - valor2;
        }
        else if(operacao == 3)
        {
           if (valor2 != 0)
            {
                resultado = valor1 / valor2;
            }
           else
            {
                Console.WriteLine("Erro! Não é possível dividir por zero.");
                return;
            }
        }
        else if (operacao == 4)
        {
            resultado = valor1 * valor2;
        }
        else
        {
            Console.WriteLine("Opção inválida!");
            return;
        }

        Console.WriteLine("O resultado da operação é: " + resultado);
        Console.ReadKey();
    }
}