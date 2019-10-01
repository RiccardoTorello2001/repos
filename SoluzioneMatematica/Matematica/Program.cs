using LibreriaMatematica;
using System;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            int somma = Operazioni.Somma(n1, n2);
            int differenza = Operazioni.Differenza(n1, n2);
            int prodotto = Operazioni.Prodotto(n1, n2);
            double quoziente = Operazioni.Quoziente(n1, n2);
            Console.WriteLine($"Somma = {somma}");
            Console.WriteLine($"Differenza = {differenza}");
            Console.WriteLine($"Prodotto = {prodotto}");
            Console.WriteLine($"Quoziente = {quoziente}");
            Console.ReadLine();
        }
    }
}
