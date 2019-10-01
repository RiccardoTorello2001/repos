using System;

namespace LibreriaMatematica
{
    public class Operazioni
    {
        public static int Somma(int a, int b)
        {
            int somma = a + b;
            return somma;
        }
        public static int Differenza(int a, int b)
        {
            int differenza = a - b;
            return differenza;
        }
        public static int Prodotto(int a, int b)
        {
            int prodotto = a * b;
            return prodotto;
        }
        public static double Quoziente(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Divisore = 0");
            }
            double quoziente = a / b;
            return quoziente;
        }
    }
}
