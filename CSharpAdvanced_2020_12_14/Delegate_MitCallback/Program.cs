using System;

namespace Delegate_MitCallback
{
    class Program
    {
        public delegate void Del(string message);
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }


        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            //Berechne etwas komplexes


            //Callback wird ganz zum Schluss aufgerufen
            callback("The number is: " + (param1 + param2).ToString()); 
        }

        static void Main(string[] args)
        {
            Del handler = DelegateMethod;
            MethodWithCallback(12, 33, handler);
        }
    }
}
