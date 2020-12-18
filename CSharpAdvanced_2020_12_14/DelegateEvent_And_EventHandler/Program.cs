using System;

namespace DelegateEvent_And_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic pbl = new ProcessBusinessLogic();
            pbl.ProcessCompleted += Pbl_ProcessCompleted;
            pbl.StartProcess();


            ProcessBusinessLogic2 bl2 = new ProcessBusinessLogic2();
            bl2.ProcessCompleted += Bl2_ProcessCompleted;
            bl2.ProcessCompletedNew += Bl2_ProcessCompletedNew;

            bl2.StartProcess();


            Console.ReadKey();
        }

        //Beispiel 1:
        private static void Pbl_ProcessCompleted()
        {
            //Mithilfe von Invoke komme ich in diese Methode 

            Console.WriteLine("Liebe Grüße von Pbl_ProcessCompleted()");
        }

        //Beispiel 2: 
        private static void Bl2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }
       
        //Beispiel 3:
        private static void Bl2_ProcessCompletedNew(object sender, EventArgs e)
        {
            MyEventArg myEventArg = (MyEventArg)e;

            Console.WriteLine($"Fertig am {myEventArg.Uhrzeit.ToString()}");
        }
    }
}
