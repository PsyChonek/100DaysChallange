using System;
using System.Diagnostics.Tracing;

namespace _27.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,5,4,5 };
            Console.WriteLine(MaxProduct(nums));
        }

        static int MaxProduct(int[] nums)
        {
            int Max = int.MinValue;

            for (int J = 0; J < nums.Length; J++)
            {
                for (int I = 0; I < nums.Length; I++)
                {
                    if ((nums[J] - 1) * (nums[I] - 1) > Max && I != J)
                    {
                        Max = (nums[J] - 1) * (nums[I] - 1);
                    }
                }
            }
            return Max;
            
        }
    }
}
