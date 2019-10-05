using Libreria_Calcolo;
using System;
using System.Collections.Generic;
using System.Text;

namespace matematica
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("che operazione vuoi fare?(somma/diffederenza/moltiplicazione/divisione/max/potenza)");
            string risposta = Console.ReadLine();
            double risultato;
            switch (risposta)
            {
                case "somma":
                    risultato = Operazioni.Somma(a, b);
                    break;
                case "differenza":
                    risultato = Operazioni.Sottrazioni(a, b);
                    break;
                case "moltiplicazione":
                    risultato = Operazioni.Moltiplicazione(a, b);
                    break;
                case "divisione":
                    risultato = Operazioni.Divisione(a, b);
                    break;
                case "max":
                    risultato = Operazioni.Massimo(a, b);
                    break;
                case "potenza":
                    risultato = Operazioni.Potenza(a, b);
                    break;
                default:
                    throw new Exception("scelta non valida");

            }
            Console.WriteLine(risultato);
            Console.ReadLine();
        }

    }
}
