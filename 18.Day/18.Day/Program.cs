using System;
using System.Collections.Generic;

namespace _18.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, start = 7;

            Console.WriteLine(XorOperation(n, start));


        }

        static int XorOperation(int n, int start)
        {
            int Temp = start;

            for (int P = 1; P < n; P++)
            {
                Temp = Temp ^ start + 2 * P;
            }
            return Temp;
        }
    }
}
