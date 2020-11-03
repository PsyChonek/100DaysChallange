using System;

namespace _24.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat = new int[1][];
            mat[0] = new int[] { 5 };


            Console.WriteLine(DiagonalSum(mat));
        }
        static int DiagonalSum(int[][] mat)
        {
            int result = 0;
            int num = 0;

            for (int P = 0; P < mat.Length; P++)
            {
                result += mat[P][P];
            }

            if (mat.Length % 2 != 0)
            {
                result -=mat[(mat.Length) / 2][(mat[(mat.Length) / 2].Length) / 2];
            }

            for (int P = mat.Length-1; P >= 0; P--)
            {
                result += mat[P][num];
                num++;
            }

            return result;
        }
    }
}
