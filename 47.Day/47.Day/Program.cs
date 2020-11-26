using System;
using System.Collections.Generic;

namespace _47.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[2][];

            input[0] = new int[] { 7,8};
            input[1] = new int[] { 1,2 };


            Console.WriteLine(LuckyNumbers(input)[0]);
        }

        static IList<int> LuckyNumbers(int[][] matrix)
        {
            IList<int> output = new List<int>();

            
            for (int P = 0; P < matrix.Length; P++)
            {
                int minrow = int.MaxValue;
                int minrowindex = 0;
                bool check = false;

                for (int T = 0; T < matrix[P].Length; T++)
                {
                    if (minrow > matrix[P][T])
                    {
                        minrow = matrix[P][T];
                        minrowindex = T;
                    }
                }

                for (int C = 0; C < matrix.Length; C++)
                {
                    if (minrow < matrix[C][minrowindex])
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }

                if (check)
                output.Add(minrow);

            }


            return output;
        }
    }
}
