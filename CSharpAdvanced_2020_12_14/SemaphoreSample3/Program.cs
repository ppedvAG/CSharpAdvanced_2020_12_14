using System;
using System.Threading;

namespace SemaphoreSample3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            SemaphoreZähler zähler = new SemaphoreZähler();

            for (int i = 0; i < 500; i++)
                new Thread(zähler.MachWas).Start();


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        
    }

    public class SemaphoreZähler
    {
        private static Semaphore semaphore = new Semaphore(3, 3);
        private static int zähler = 0;
        public void MachWas()
        {
            semaphore.WaitOne();
            zähler++;
            Console.WriteLine(zähler);
            zähler--;
            semaphore.Release();

        }
    }

    
}
