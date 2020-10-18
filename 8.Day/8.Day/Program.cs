using System;

namespace _8.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            foreach (int num in Shuffle(nums, n))
            {
                Console.Write(num +" ");
            }

            
;        }

        static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];

            result[0] = nums[0];
            result[result.Length - 1] = nums[result.Length - 1];

            for (int P = 1; P < result.Length / 2; P++)
            {
                result[P + P] = nums[P];
            }
            int N = 1;
            for (int P = result.Length-2; P >= result.Length / 2; P--)
            {
                result[P - N] = nums[P];
                N++;
            }

            return result;
        }
    }
}
