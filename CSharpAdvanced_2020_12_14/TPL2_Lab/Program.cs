using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TPL2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<List<long>> task1 = Task.Run(() => GetPrimeNumbers(2500));

            task1.ContinueWith(
            primeNumbers =>
            {
                for(int i = 0; i < primeNumbers.Result.Count)
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            /* In dieser Übung soll eine Ermittlung von Primzahlen mit TPL unterstützt werden
             * Im ersten Task soll die Ermittlung der Primzahlen (GetPrimeNumbers) statt finden.
             * 
             * Im Folge-Task soll die Liste der Primzahlen ausgegeben werden. Hier wird mit ContinueWith gearbeitet. 
             */
        }

        public static List<long> GetPrimeNumbers(long until)
        {
            List<long> retValues = new List<long>();
            for (int i = 0; i < until; i++)
            {
                i++;
                if (chkprime(i))
                {
                    retValues.Add(i);
                }
            }

            return retValues;
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
