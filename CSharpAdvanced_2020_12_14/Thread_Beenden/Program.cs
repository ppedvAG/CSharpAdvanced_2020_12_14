using System;
using System.Threading;

namespace Thread_Beenden
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MachEtwas);
            t.Start();
            Thread.Sleep(3000);
            t.Interrupt();

            Console.ReadKey();
        }

        private static void MachEtwas()
        {
            try
            {
                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(100);

                    Console.WriteLine("zZzZ");
                }
            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine((string)ex.Message);
            }
            catch(ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
            
        }
    }


}
