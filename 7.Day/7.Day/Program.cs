using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = { 0, 2, 6, 4, 5, 4 };
            int[] q = { 1, 6, 6, 5, 5, 0, 5, 5, 5 };

            Console.WriteLine(pairs(p, q));

            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;

            foreach(bool test in KidsWithCandies(candies, extraCandies))
            {
                Console.WriteLine(test);
            }           
        }

        static int pairs(int[] p, int[] q)
        {
            int count = 0;
            int lenght = p.Length;

            if (p.Length > q.Length)
            {
                lenght = q.Length;
            }

            for (int P = 0; P < lenght; P++)
            {
                if (p[P] == q[P])
                {
                    count++;
                }
            }
            return count;
        }


        // Kids With the Greatest Number of Candies

        static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> ilist = new List<bool>();
            int max = MaxValue(candies);

            foreach (int candy in candies)
            {
                if(candy + extraCandies >= max)
                {
                    ilist.Add(true);
                }
                else
                {
                    ilist.Add(false);
                }
            }
            return ilist;
        }

        static int MaxValue(int[] candies)
        {
            int max = 0;
            foreach(int number in candies)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
    }
}
