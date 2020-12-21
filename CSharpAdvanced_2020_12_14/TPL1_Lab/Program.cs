using System;

namespace TPL1_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TPL Übung mit CancelationTokenSource
             * In dieser Aufgabe soll die Methode ShowPrimeNumbers eine Möglichkeit bekommen, dass man 
             * den Primzahlen Algorithmus von aussen beenden kann. 
             * 
             * Der Primzahlalgorithmus soll nach 20 Sekunden automatisch von der Main-Methode beendet werden 
             */


        }

        public static void ShowPrimeNumbers()
        {
            long i = 0;

            while (true)
            {
                i++;
                if (chkprime(i))
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }

        private static bool chkprime(long num)
        {
            for (long i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
    }

    
}
