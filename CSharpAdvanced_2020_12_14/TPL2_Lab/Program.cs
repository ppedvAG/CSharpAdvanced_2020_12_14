using System;
using System.Collections.Generic;

namespace TPL2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
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
