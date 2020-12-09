using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Day
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] grid = new int[1][];
            grid[0] = new int[] { 1, 0 };


            Console.WriteLine(IslandPerimeter(grid));

        }

        static int IslandPerimeter(int[][] grid)
        {
            int result = 0;

            for (int C = 0; C < grid.Length; C++)
            {
                for (int R = 0; R < grid[C].Length; R++)
                {
                    if (C == 0)
                    {
                        if (grid[C][R] == 1)
                        {
                            if (R > 0)
                            {
                                if (grid[C][R - 1] == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                result++;
                            }

                            if (R < grid[C].Length - 1)
                            {
                                if (grid[C][R + 1] == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                result++;
                            }

                            if (grid.Length - 1 > 0)
                            {
                                if (grid[C + 1][R] == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                result++;
                            }

                            result++;
                        }
                    }

                    // OK

                    else if (C == grid.Length - 1)
                    {

                        if (grid[C][R] == 1)
                        {
                            if (R > 0)
                            {
                                if (grid[C][R - 1] == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                result++;
                            }

                            if (R < grid[C].Length - 1)
                            {
                                if (grid[C][R + 1] == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                result++;
                            }

                            if (grid[C - 1][R] == 0)
                            {
                                result++;
                            }

                            result++;
                        }
                    }

                    // OK

                    else
                    {
                        if (grid[C][R] == 1)
                        {
                            if (R > 0)
                            {
                                if (grid[C][R - 1] == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                result++;
                            }

                            if (R < grid[C].Length - 1)
                            {
                                if (grid[C][R + 1] == 0)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                result++;
                            }

                            if (grid[C - 1][R] == 0)
                            {
                                result++;
                            }

                            if (grid[C + 1][R] == 0)
                            {
                                result++;
                            }
                        }

                    }
                }
            }

            return result;
        }
    }
}
