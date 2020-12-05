using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,3 };
            int target = 6;

            foreach(int I in TwoSum(nums, target))
            Console.WriteLine(I);
        }

        static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int P = 0; P < nums.Length; P++)
            {
                for (int T = P + 1; T < nums.Length; T++)
                {
                    if (nums[P] + nums[T] == target)
                    {
                        result[0] = P;
                        result[1] = T;
                        return result;
                    }


                }
            }


            return result;

        }
    }
}
