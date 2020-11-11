using System;

namespace _32.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid =
            {
              new int[] {4,3,2,-1},
              new int[] { 3,2,1,-1 },
              new int[] { 1, 1, -1, -2 },
              new int[] { -1, -1, -2, -3 }
            };

            Console.WriteLine(CountNegatives(grid));
        }

        static int CountNegatives(int[][] grid)
        {
            int result = 0;

            for ( int P = 0; P < grid.Length; P++)
            {
                foreach (int I in grid[P])
                {
                    if (I < 0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
