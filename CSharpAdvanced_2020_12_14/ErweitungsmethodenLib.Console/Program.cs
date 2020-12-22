

namespace ErweitungsmethodenLib.Console
{
    using System;
    using System.Collections.Generic;
    using ErweitungsmethodenLib;
    class Program
    {
        static void Main(string[] args)
        {
            int i = 111;

            i.Verdoppeln();
            Console.WriteLine(i);


            IList<int> numberList = new List<int>();
            numberList.ErweitereListe();
            
            
            List<int> numberList2 = new List<int>(); //List<T> : IList<T> Implementierung
            numberList2.ErweitereListe();

            Console.ReadLine();
        }
    }
}
