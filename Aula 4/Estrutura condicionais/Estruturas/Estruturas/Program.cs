using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma nota:");
        float nota = float.Parse(Console.ReadLine());
        if (nota >= 9)
        {
            Console.WriteLine("A");
        }
        if (nota == 8.0 && nota <= 9.0)
             Console.WriteLine("B");
        {
           
        }
        if (nota == 7.0 && nota <= 8.0)
        {
            Console.WriteLine("C");
        }
        if (nota == 5.0 && nota <= 7.9)
        {
            Console.WriteLine("D");
        }
        if (nota < 5)
        {
            Console.WriteLine("F");
        }
        Console.ReadKey();
    }
}
   