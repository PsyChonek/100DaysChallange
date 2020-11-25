using System;

namespace _45.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = {1,10,10,10,19};
            Console.WriteLine(CanMakeArithmeticProgression(input));
        }
        static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int dif = arr[0] - arr[1];
            for (int P = 0; P < arr.Length-1; P++)
            {
                if (arr[P] - arr[P+1] != dif)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
