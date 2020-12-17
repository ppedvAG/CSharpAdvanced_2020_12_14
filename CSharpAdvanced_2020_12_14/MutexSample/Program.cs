using System;
using System.Threading;

namespace MutexSample
{
    class Program
    {
        private static Mutex mutex = null;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        private static void DoSomething()
        {
            mutex = new Mutex(false, "MyMutex");

            bool lockTaken = false;


            try
            {
                lockTaken = mutex.WaitOne(); //lockTaken wird auf True gesetzt = Zweiter Thread muss warten

                //Kritischer Codeblock

            }
            finally
            {
                if (lockTaken == true)
                {
                    mutex.ReleaseMutex(); // Bereich wird wieder freigegeben 
                }
            }

        }
    }
}
