using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEvent_And_EventHandler
{
    public class ProcessBusinessLogic2
    {
        public event EventHandler ProcessCompleted;
        public event EventHandler ProcessCompletedNew;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");

            //Mache etwas!!!!

            MyEventArg myEventArg = new MyEventArg();
            myEventArg.Uhrzeit = DateTime.Now;

            OnProcessCompleted(EventArgs.Empty); //No event data -> Beispiel1
            OnProcessCompletedNew(myEventArg); //Beispiel 2
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }

        protected virtual void OnProcessCompletedNew(MyEventArg e)
        {
            ProcessCompletedNew?.Invoke(this, e);
        }



    }


    public class MyEventArg : EventArgs
    {
        public DateTime Uhrzeit { get; set; }
    }
}
