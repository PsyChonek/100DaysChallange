using System;
using System.Collections.Generic;

namespace _30.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aaaabbbbcccc";
            Console.WriteLine(SortString(s));
        }
        static string SortString(string s)
        {
            List<char> newList = new List<char>();

            int max = int.MinValue;
            int min = int.MaxValue;

            max = Max(max, s);
            min = Min(min, s);

            int tempMax = max;
            int tempMin = min;

            for (int P = 0; P < s.Length; P++)
            {
                if ((int)s[P] == min)
                {
                    newList.Add(s[P]);
                    tempMax = Min(min, s);

                }
                if ((int)s[P] > min && (int)s[P] < max)
                {

                }
            }


            return new string(newList.ToArray());
        }
        static int Min(int M, string s)
        {
            int min = M;
            for (int P = 0; P < s.Length; P++)
            {
                if (min > (int)s[P]&& min != M )
                {
                    min = (int)s[P];
                }
            }
            return min;
        }
        static int Max(int M, string s)
        {
            int max = M;
            for (int P = 0; P < s.Length; P++)
            {
                if (max > (int)s[P] && max != M)
                {
                    max = (int)s[P];
                }
            }
            return max;
        }

    }
}
