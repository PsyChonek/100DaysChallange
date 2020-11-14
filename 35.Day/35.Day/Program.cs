using System;

namespace _35.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 3 };
            Console.WriteLine(RepeatedNTimes(A));
        }
        static int RepeatedNTimes(int[] A)
        {
            for (int P = 0; P<A.Length;P++)
            {
                for (int T = P+1; T<A.Length; T++)
                {
                    if (A[P] == A[T])
                    {
                        return A[P];
                    }
                }
            }
            return 0;
        }
    }
}
