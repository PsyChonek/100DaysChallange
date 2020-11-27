using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] input = { 4, 2, 5, 7 };

            foreach (int i in SortArrayByParityII(input))
                Console.WriteLine(i);
        }

        static int[] SortArrayByParityII(int[] A)
        {
            int[] output = new int[A.Length];

            int odd = 0;
            int even = 1;

            for (int P = 0; P < A.Length; P++)
            {
                if (A[P] % 2 == 0)
                {
                    output[odd] = A[P];
                    odd += 2;
                }
                else
                {
                    output[even] = A[P];
                    even += 2;
                }


            }

            return output;
        }
    }
}
