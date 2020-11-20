using System;
using System.Collections.Generic;

namespace _40.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { -4, -1, 0, 3, 10 };
            foreach (int T in SortedSquares(input))
            Console.WriteLine(T);
        }
        static int[] SortedSquares(int[] A)
        {
            List<int> result = new List<int>();

            foreach (int I in A)
            {
                result.Add(Convert.ToInt32(Math.Pow(I, 2)));
            }
            result.Sort();
            return result.ToArray();
        }
    }
}
