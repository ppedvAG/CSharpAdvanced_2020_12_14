using System;
using System.Threading;

namespace ThreadMitParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart paramThreadStart = new ParameterizedThreadStart(MachEtwasInEinemThreadMitParameter); //MachEtwasInEinemThreadMitParameter bietet einen Parameter vom Typ object an
            Thread thread = new Thread(paramThreadStart); //Methode mit Parameter wird dem Thrad bekannt gemacht.
            thread.Start(123); //Starte Thread und gebe für den object Parameter einen Wert an. 
            thread.Join();

            //thread.Abort(); // Thread wird abggebrochen. 

            Console.WriteLine("Bin fertig!");
            Console.ReadKey();
        }

        
        private static void MachEtwasInEinemThreadMitParameter(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                //Thread.Sleep(500);
                Console.Write("#");
            }
        }
    }
}
