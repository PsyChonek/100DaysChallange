using System;

namespace _41.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };
            Console.WriteLine(PeakIndexInMountainArray(input));
        }
        static int PeakIndexInMountainArray(int[] arr)
        {
            int result = 0;
            while (arr[result] < arr[result + 1])
            result++;
            return result;
        }
    }
}
