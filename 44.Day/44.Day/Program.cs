using System;
using System.Collections.Generic;

namespace _44.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 10, 9, 8};

            Console.Write("Input: ");
            foreach (int I in nums)
                Console.Write(I + " ");

            Console.WriteLine();

            foreach (int I in MinSubsequence(nums))
                 Console.Write(I + " ");
        }
        static IList<int> MinSubsequence(int[] nums)
        {
            int sum = 0;
            int min = 0;
            IList<int> result = new List<int>();


            foreach (int S in nums)
            {
                sum += S;
            }

            Console.WriteLine("Sum: " + sum);

            for (int P = 0; P < nums.Length-1; P++)
            {
                for (int T = 0; T < nums.Length-1; T++)
                {
                    if (nums[T] < nums[T + 1])
                    {
                        int temp = nums[T];
                        nums[T] = nums[T + 1];
                        nums[T + 1] = temp;
                    }
                }
            }

            for (int P = 0; P < nums.Length; P++)
            {
                sum -= nums[P];
                min += nums[P];
                result.Add(nums[P]);
                if (sum < min)
                {
                    break;
                }
            }

            return result;
        }
    }
}
