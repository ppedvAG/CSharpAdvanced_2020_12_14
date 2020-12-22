using System;

namespace OperatorenSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruch b1 = new Bruch(1, 2);
            Bruch b2 = new Bruch(1, 4);

            Bruch erg = b1 * b2;
            Bruch erg2 = b1 * 3;

            b1 *= 12; 
        }
    }
}
