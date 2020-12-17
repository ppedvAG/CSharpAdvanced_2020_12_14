using System;
using System.Threading;

namespace ThreadPoolSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Methode1); //Erstelle einen Thread und führe Thread.Start aus
            ThreadPool.QueueUserWorkItem(Methode2);
            ThreadPool.QueueUserWorkItem(Methode3);

            Console.ReadKey();
        }


        private static void Methode1(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.Write("#");
            }
        }

        private static void Methode2(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.Write("-");
            }
        }

        private static void Methode3(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.Write("*");
            }
        }
    }
}
