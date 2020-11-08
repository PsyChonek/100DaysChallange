using System;
using System.Collections.Generic;
namespace _29.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            foreach (int I in SumZero(n))
            {
                Console.WriteLine(I);
            }
            
        }
        static int[] SumZero(int n)
        {
            List<int> numbers = new List<int>();

            for (int P = n; P > 0; P--)
            {
                if (P % 2 == 0)
                {
                    numbers.Add(P);
                    numbers.Add(P * -1);
                    P--;
                }
                else
                {
                    numbers.Add(0);
                }
            }

            return numbers.ToArray();
        }
    }
}
