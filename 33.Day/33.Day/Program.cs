using System;
using System.Collections.Generic;

namespace _33.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int left = 1, right = 22;


            foreach (int I in SelfDividingNumbers(left, right))
            {
                Console.WriteLine(I);
            }
        }

        static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> result = new List<int>();

            for (int P = left; P <= right; P++)
            {
                string test = P.ToString();
                Boolean check = true;

                foreach (char T in test)
                {                 
                    if (T == '0' || P % int.Parse(T.ToString()) != 0)
                    {
                        check = false;
                    }
                }

                if (check)
                {
                    result.Add(P);
                }

            }

            return result;
        }
    }
}
