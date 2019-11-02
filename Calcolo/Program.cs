using Libreria_Calcolo;
using System;

namespace matematica
{
    class Program
    {
        private static string risposta;

        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo numero");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("inserisci il secondo numero");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("che operazione vuoi fare?(somma/diffederenza/moltiplicazione/divisione/max/potenza)");
            string risposta = Console.ReadLine();
            double risultato;
            try
            {
                if (risposta == "somma")
                    risultato = Operazioni.Somma(a, b);
                else if (risposta == "sottrazione")
                    risultato = Operazioni.Sottrazioni(a, b);
                else if (risposta == "divisione")
                    risultato = Operazioni.Divisione(a, b);
                else if (risposta == "Moltiplicazione")
                    risultato = Operazioni.Moltiplicazione(a, b);
                if (risposta == "potenza")
                    risultato = Operazioni.Potenza(a, b);

                else if (risposta == "max")
                    risultato = Operazioni.Massimo(a, b);
                else risultato = double.NaN;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                risultato = double.NaN;
            }
            Console.WriteLine(risultato);
            Console.ReadLine();
        }
    }
}
