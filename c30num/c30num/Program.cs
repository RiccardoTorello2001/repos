using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c30num
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dichiaro e inizializzo la mia collezione dati
            int[] Vettore = new int[30];
            int[] VettoreMax = new int[30];
            int[] VettoreMin = new int[30];

            //Dichiaro e inizializzo le mie variabili
            int da = 1;
            int a = 21;
            int valoreRandom = 0;
            int cmin = 0;
            int cmax = 0;

            //Definisco il mio generatore di numeri
            Random random = new Random();

            //Attraverso un ciclo FOR popolo il mio vettore di 30 posizioni
            for (int i = 0; i < 30; i++)
            {
                Vettore[i] = random.Next(1, 21);  //genera un numero tra 1 e 20
            }



            //Attraverso un ciclo FOR stampo il contenuto del vettore
            for (int i = 0; i < 30; i++)
            {

                Console.WriteLine("Il mio valore random per il mio vettore è: {0}", Vettore[i]);

            }



            //Attraverso un ciclo FOR stampo il contenuto del vettore e ne popolo altri due con valori min<10 e max>=10
            for (int i = 0; i < 30; i++)
            {

                // Console.WriteLine("Il mio valore random per il mio vettore è: {0}", Vettore[i]);

                //Attraverso una IF controllo i valori minori di 10 e quelli maggiori o uguali a 10
                if (Vettore[i] < 10)
                {
                    VettoreMin[cmin] = Vettore[i];
                    cmin++;
                }

                else if (Vettore[i] >= 10)
                {
                    VettoreMax[cmax] = Vettore[i];
                    cmax++;
                }

            }

            //Attraverso un ciclo for stampo il contenuto dei miei due nuovi vettori
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(VettoreMin[i] + "  " + VettoreMax[i]);
                // Console.WriteLine();
                // Console.WriteLine("Il mio valore random per il mio vettoreMax è: {0}", VettoreMax[i]);
            }

            //Chiudo il programma
            Console.ReadLine();
        }
    }
}
