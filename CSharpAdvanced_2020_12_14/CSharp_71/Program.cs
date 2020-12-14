using System;

namespace CSharp_71
{
    class Program
    {
        static void Main(string[] args)
        {
            #region abgeleiteter Tupelname
            string name = "Muster";
            int valueOfDay = 123;

            var tupel = (name, valueOfDay);

            //tupel.name / tupel.valueOfDay
            Console.WriteLine(tupel.name);
            Console.WriteLine(valueOfDay.ToString());
            #endregion
        }
    }
}
