using System;
using System.Threading;
using System.Threading.Tasks;

namespace _004a_Task_Pausieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class MySimpleTaskScheduler
    {
        private volatile bool isPaused;
        private volatile bool isStopped;
        private Task _myBackgroundTask;

        public void StartTask()
        {
            _myBackgroundTask = new Task.Run(() =>
            {
                while (!isStopped)
                {
                    while (!isPaused && !isStopped)
                    {
                        //.. do something
    
                        Thread.Sleep(100);  // set some delay before check if task is set on pause
                    }

                    Thread.Sleep(100);  // set some timeout before check if task is stopped              
                }
            });
        }

        public void Pause()
        {
            isPaused = true;
        }

        public void Resume()
        {
            isPaused = false;
        }

        public void Stop()
        {
            isPaused = true;
            isStopped = true;
        }
    }
}
