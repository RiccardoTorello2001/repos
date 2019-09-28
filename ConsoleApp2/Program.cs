using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somma tra 2 numeri");
            Console.WriteLine("Inserisci il primo numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero: ");
            double n2 = double.Parse(Console.ReadLine());
            double somma = n1 + n2;
            Console.Write($"La somma è: {somma}");
            Console.ReadLine();
        }
    }
}
