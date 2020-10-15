using System;
using System.Linq;

namespace _5.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Stairs(Int32.Parse(Console.ReadLine())));
        }

        static int Stairs(int ways)
        {
            int a = 1;
            int b = 2;
            foreach (int value in Enumerable.Range(1, 10))
            {
                int c = a + b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}
