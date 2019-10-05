using System;

namespace Libreria_Calcolo
{
    public class Operazioni
    {
        public static int Somma(int a, int b)
        {
            int s = a + b;
            return s;
        }
        public static int Sottrazioni(int a, int b)
        {
            int d = a - b;
            return d;
        }
        public static int Moltiplicazione(int a, int b)
        {
            int m = a * b;
            return m;
        }
        public static double Divisione(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b = 0 ");

            }
            double q = a / b;
            return q;
        }
        public static int Potenza(int a, int b)
        {
            int c = 0;
            while (c < b)
            {
                c++;
                a = a * a;
            }
            return a;
        }
        public static double Massimo(int a, int b)
        {
            double max;
            if (a >= b)
            {
                max = a;


            }
            else
            {
                max = b;
            }
            return max;
        }
    }
}

       