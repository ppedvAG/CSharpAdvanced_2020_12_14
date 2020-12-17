using System;
using System.Threading;
using System.Threading.Tasks;

namespace _004_Task_Beenden
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Task task = Task.Factory.StartNew(MeineMethodeMitAbbrechen, cts);
            Thread.Sleep(10000);
            Console.WriteLine("Jetzt wird der Task geschlossen:");
            cts.Cancel(); //Geben das Signal, dass der Task beendet wird.
            Console.ReadKey();
        }

        private static void MeineMethodeMitAbbrechen(object param)
        {
            CancellationTokenSource source = (CancellationTokenSource)param;

            while (true)
            {
                Console.WriteLine("zzz......zzzzz");
                Thread.Sleep(50);

                if (source.IsCancellationRequested)
                    break;
            }
        }
    }
}
