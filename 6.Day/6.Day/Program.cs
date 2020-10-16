using System;

namespace _6.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            RunningSum(nums);
            foreach(int number in nums)
            {
                Console.Write(number + " ");
            }
        }

        static int[] RunningSum(int[] nums)
        {
            for (int P = 1; P < nums.Length; P++)
            {             
                    nums[P] += nums[P - 1];                
            }
            return nums;
        }
        


    }
}
