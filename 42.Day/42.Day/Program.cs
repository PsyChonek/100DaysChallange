using System;

namespace _42.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = { 5, 1, 2, 3, 4 };
            Console.WriteLine(HeightChecker(heights));
        }
        static int HeightChecker(int[] heights)
        {
            int result = 0;

            int[] sorted = new int[heights.Length];

            for (int i = 0; i < heights.Length; i++)
            {
                sorted[i] = heights[i];
            }

            Array.Sort(sorted);

            for (int P = 0; P < heights.Length; P++)
            {
                if (heights[P] != sorted[P])
                {
                    result++;
                }
            }
            return result;
        }
    }
}
