using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite o ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        Console.Write("Digite o ano atual: ");
        int anoAtual = int.Parse(Console.ReadLine());

        int idadeAnos = anoAtual - anoNascimento;

        int idadeMeses = idadeAnos * 12;

        int idadeDias = idadeAnos * 365;

        int idadeSemanas = idadeDias / 7;

        Console.WriteLine("Idade em anos: " + idadeAnos);
        Console.WriteLine("Idade em meses: " + idadeMeses);
        Console.WriteLine("Idade em dias: " + idadeDias);
        Console.WriteLine("Idade em semanas: " + idadeSemanas);
        Console.Read();
    }
}
