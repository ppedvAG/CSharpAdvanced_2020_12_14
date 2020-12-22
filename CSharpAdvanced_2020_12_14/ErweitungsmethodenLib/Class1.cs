using System;
using System.Collections.Generic;

namespace ErweitungsmethodenLib
{
    public static class IntegerErweiterungsMethoden
    {
        public static int Verdoppeln(this int input)
        {
            return input * 2;
        }

        public static void ErweitereListe(this IList<int> input)
        {
            input.Add(111);
            input.Add(222);
        }
    }
}
