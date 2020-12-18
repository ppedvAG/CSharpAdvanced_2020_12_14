using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_mit_ConcurrentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();


            //Task 1 -> Hinzugügen von 100 Elemente in dictionary (ConcrruentDictionary)
            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; ++i)
                {

                    dictionary.TryAdd(i.ToString(), i.ToString());
                    Thread.Sleep(100);
                }

                Console.WriteLine($"Anzahl aller Einträge: {dictionary.Count}");
            });

            // Task 2 -> Auslesen aller Datensätze von dictionary
            Task t2 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(300); 
                foreach (var item in dictionary) //Nimmt eine Art Kopie vom dictionary und arbeitet mit mit der Kopie-Menge von Items
                {
                    Console.WriteLine(item.Key + "-" + item.Value);
                    Thread.Sleep(150);
                }
            });

            try
            {
                Task.WaitAll(t1, t2); //Warten bis beide Tasks fertig sind
            }
            catch (AggregateException ex) // No exception
            {
                Console.WriteLine(ex.Flatten().Message);
            }
        }
    }
}
