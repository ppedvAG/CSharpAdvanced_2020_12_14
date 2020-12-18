using System;

namespace Delegates_Events
{
    class Program
    {
        //Erstellen eines eigenen Delegate-Typs
        delegate int NumbChange(int n); //Zeiger auf einer Methode/Funktion 
        

        
        
        static int num = 10;
        static void Main(string[] args)
        {
            #region Delegate
            NumbChange nc1 = new NumbChange(AddNum);
            nc1(12); //Ruft AddNum auf

            Console.WriteLine("2ter Call mit 2 angehängten Methoden");

            nc1 += MultNum;
            nc1(25); //Ruft AddNum + MultNum auf

            nc1 -= AddNum;
            nc1(13); // Ruft nur MultNum auf



            NumbChange numberChanger1 = new NumbChange(AddNum);
            NumbChange numberChanger2 = new NumbChange(MultNum);
            nc1 = numberChanger1;
            nc1(11); //Es wird nur AddNum aufgerufen 

            nc1 += numberChanger2;
            nc1(13); //Es werden beide Methoden aufgerufen. 
            #endregion


            #region Action<T> und Func<T>
            // Action hat kein Rückgabewert. 
            Action a1 = new Action(A);
            a1 += B;

           // Action<int> a2a = new Action<int>(C);
            Action<int> a2 = C; //Kurzschreibweise zu -> Action a1 = new Action(A);
            a2(123);

            Action<int, int, int> a3 = AddNums;
            a3(123, 565, 222);


            Func<int, int, int> rechner = Add; //Letzter Parameter ist der Rückgabewert!
            int result = rechner(33, 66);

            #endregion

            Console.ReadKey();
        }
        public static int Add(int z1, int z2)
        {
            return z1 + z2;
        }

        #region Methoden zum Kapseln 
        public static int AddNum(int p)
        {
            num += p;
            Console.WriteLine("AddNum is called");
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            Console.WriteLine("MultNum is called");
            return num;
        }
        #endregion

        #region Methoden zu Action und Function
        public static void A()
        {
            Console.WriteLine("A");
        }

        public static void B()
        {
            Console.WriteLine("B");
        }

        static void C(int zahl)
        {
            Console.WriteLine("C" + zahl);
        }

        public static void AddNums(int a, int b, int c)
        {
            int result = a + b + c;

            Console.WriteLine($"{result}");
        }



       
        #endregion
    }
}
