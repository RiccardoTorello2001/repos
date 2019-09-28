using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //grandezza campo gioco e navi
            int grand = 0, navi = 0;

            Console.WriteLine("Inserisci grandezza campo");
            do
            {
                grand = Convert.ToInt32(Console.ReadLine());
                if (grand < 4 || grand > 10)
                {
                    Console.WriteLine("Errore! inserisci un numero tra 4 e 10");
                }
            } while (grand < 4 || grand > 10); //controllo posizione errata

            //numero navi
            Console.WriteLine("Inserisci numero navi");
            do
            {
                navi = Convert.ToInt32(Console.ReadLine());
                if (navi < 2 || navi > grand - 1)
                {
                    Console.WriteLine("Errore! inserisci un numero tra 2 e " + (grand - 1)); //controllo navi
                }
            } while (navi < 2 || navi > grand - 1);

            //definisco i campi di bataglia
            int[] altr = new int[grand];
            int[] avve = new int[grand];
            int[] alle = new int[grand];

            for (int i = 0; i < navi; i = i + 1)
            {
                Console.WriteLine("Scrivi 1 se vuoi la nave nella cella " + i);
                do
                {
                    alle[i] = Convert.ToInt32(Console.ReadLine());
                    if (alle[i] > 1 || alle[i] < 0)
                    {
                        Console.WriteLine("Errore! devi inserire 1 o 0!");
                    }
                } while (alle[i] > 1 || alle[i] < 0);

            }

            Console.Clear(); //pulisco lo schermo

            for (int i = 0; i < grand; i = i + 1)
            {
                Console.WriteLine("Posizione:" + altr[i] + "  Avversario:" + avve[i] + "  Noi:" + alle[i]);
            }
            Console.ReadLine();
        }
    }
}
