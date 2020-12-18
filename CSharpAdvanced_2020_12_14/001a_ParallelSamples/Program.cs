using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001a_ParallelSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Parallel.Invoke(Zähle, Zähle, Zähle, Zähle); //Wird 4x gleichzeitig gestartet 

            var text = new List<string>(new[] { "Dies", "ist", "ein", "Text" });
            text.ForEach(abc => Console.WriteLine(abc));

            List<string> strList = new List<string>();

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        private static void Zähle()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}]: {i}");
                //if (i > 7) Console.ReadKey();
            }
        }
    }
}
