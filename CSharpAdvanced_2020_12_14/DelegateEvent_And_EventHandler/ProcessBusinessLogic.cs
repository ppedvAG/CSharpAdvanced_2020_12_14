using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEvent_And_EventHandler
{
    public delegate void Notify(); //delegate

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; //Event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
