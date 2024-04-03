using System;

class Program
{
    static void Main(string[] args)
    {
        double gratificacao = 237.50;

        Console.Write("Digite o salário atual do funcionário: ");
        double salarioAtual = double.Parse(Console.ReadLine());

        double novoSalario = salarioAtual + gratificacao;

        Console.WriteLine("O novo salário do funcionário, com a gratificação, é: R$" + novoSalario);
        Console.ReadKey();
    }
}
