using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Que horas termina a aula? (formato HH:MM): ");
        string horarioTermino = Console.ReadLine();

        Console.WriteLine("A aula termina às " + horarioTermino + ".");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
