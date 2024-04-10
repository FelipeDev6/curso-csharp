using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Que horas são? (formato HH:MM): ");
        string horario = Console.ReadLine();

        Console.WriteLine("O horário inserido é: " + horario);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
