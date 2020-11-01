using System;
using System.Runtime.InteropServices;

namespace _22.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 0, 1, 1, 9, 7 };
            int a = 7;
            int b = 2;
            int c = 3;

            Console.WriteLine(CountGoodTriplets(arr, a,b,c));

        }
        static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int result = 0;

            for (int Q = 0; Q < arr.Length; Q++)
            {
                for (int W = 1; W < arr.Length; W++)
                {
                    for (int E = 2; E < arr.Length; E++)
                    {
                        if (0 <= Q && Q < W && W < E && E < arr.Length)
                        {
                            if (Math.Abs(arr[Q] - arr[W]) <= a && Math.Abs(arr[W] - arr[E]) <= b && Math.Abs(arr[Q] - arr[E]) <= c)
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
