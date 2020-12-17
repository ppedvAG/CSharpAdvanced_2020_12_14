using System;
using System.Threading;

namespace ParameterloserThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MacheEtwasRechenintensives);
            thread.Start(); // Thread wird gestartet

            thread.Join(); // Join gibt an, dass wir warten, bis der Thread fertig abgearbeitet ist

            for (int i = 0; i < 100; i++)
                Console.WriteLine("+");


            Console.ReadKey();
        }

        static void MacheEtwasRechenintensives()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("#");
        }
    }
}
