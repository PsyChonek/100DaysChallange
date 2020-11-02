using System;

namespace _23.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] points = new int[3][];
            points[0] = new int[] { 1,1 };
            points[1] = new int[] { 3,4 };
            points[2] = new int[] { -1,0 };

            string input = "Hello";
            // Console.WriteLine(ToLowerCase(input));

            Console.WriteLine(MinTimeToVisitAllPoints(points));
        }

        static string ToLowerCase(string str)
        {
            return str.ToLower();
        }

        static int MinTimeToVisitAllPoints(int[][] points)
        {
            int result = 0;

            for (int P = 0; P < points.Length - 1; P++)             
            {
                int x = points[P][0];
                int y = points[P][1];

                int x_nex = points[P+1][0];
                int y_nex = points[P+1][1];


                while (x != x_nex || y != y_nex)
                {
                    if (x < x_nex && y < y_nex)
                    {
                        int x_temp = x_nex - x;
                        int y_temp = y_nex - y;
                        if (x_temp >= y_temp)
                        {
                            x += y_temp;
                            y += y_temp;
                            result += y_temp;
                        }
                        else
                        {
                            x += x_temp;
                            y += x_temp;
                            result += x_temp;
                        }

                    }
                    else if (x < x_nex && y == y_nex)
                    {
                        x++;
                        result++;
                    }
                    else if (x == x_nex && y < y_nex)
                    {
                        y++;
                        result++;
                    }

                    if (x > x_nex && y > y_nex)
                    {
                        int x_temp = x_nex - x;
                        int y_temp = y_nex - y;
                        if (x_temp <= y_temp)
                        {
                            x += y_temp;
                            y += y_temp;
                            result += y_temp*-1;
                        }
                        else
                        {
                            x += x_temp;
                            y += x_temp;
                            result += x_temp;
                        }
                    }
                    else if (x > x_nex && y == y_nex)
                    {
                        x--;
                        result++;
                    }
                    else if (x == x_nex && y > y_nex)
                    {
                        y--;
                        result++;
                    }

                }
            }

            return result;
        }
    }
}
