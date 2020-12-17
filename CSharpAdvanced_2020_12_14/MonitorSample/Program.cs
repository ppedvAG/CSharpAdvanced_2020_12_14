using System;
using System.Threading;

namespace MonitorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        static void KritischerCodeAbschnitt()
        {
            try
            {
                int x = 1;
                Monitor.Enter(x); //Codeabschnitt wird vom ersten ersten Thread gesperrt
                
                try
                {
                    x = 11;
                }
                finally
                {
                    Monitor.Exit(x); // Codeabschnitt wird wieder freigegeben 
                }
            }
            catch (SynchronizationLockException syncEx)
            {
                Console.WriteLine(syncEx.Message);
            }
        }
    }
}
