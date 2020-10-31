using System;
using System.Globalization;
using System.Collections.Generic;

namespace _21.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12, 345, 2, 6, 7896};    
            Console.WriteLine(FindNumbers(nums));
            // To.String(); Better way to do it.
        }

        static int FindNumbers(int[] nums)
        {
            int result = 0;

            for (int P = 0; P<nums.Length; P++)
            {
                List<int> num = new List<int>();
                int temp = nums[P];
                while (temp >= 10)
                {
                    num.Add(temp % 10);
                    temp /= 10;
                }
                num.Add(temp);

                if (num.Count % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }

    }
}
