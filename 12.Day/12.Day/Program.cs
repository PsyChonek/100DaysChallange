using System;
using System.Collections.Generic;

namespace _12.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = {8, 1, 2, 2, 3};

            foreach (int P in SmallerNumbersThanCurrent(nums))
            {
                Console.WriteLine(P);
            }

        }
        static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            List<int> result = new List<int>();
            
            for (int P = 0; P < nums.Length; P++)
            {
                int temp = 0;
                foreach (int num in nums)
                {
                    if (nums[P] > num)
                    {                       
                        temp++;
                    }
                }
                result.Add(temp);
            }
            return result.ToArray();
        }
    }
}
