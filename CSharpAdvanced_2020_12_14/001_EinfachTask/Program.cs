using System;
using System.Threading;
using System.Threading.Tasks;

namespace _001_EinfachTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task easyTask = new Task(IchMacheEtwasImTask);
            easyTask.Start();

            easyTask.Wait(); //ist das selbe wie Thread.Join

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write("*");
            }

            Console.ReadKey();
        }


        private static void IchMacheEtwasImTask()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write("#");
            }
        }
    }
}
