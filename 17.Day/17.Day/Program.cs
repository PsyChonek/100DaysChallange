using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _17.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };

            foreach (int V in CreateTargetArray(nums, index))
            {
                Console.WriteLine(V);
            }

        }
        static int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> result = new List<int>();

            for (int P = 0; P < nums.Length; P++)
            {
                result.Insert(index[P], nums[P]);
            }
            return result.ToArray();



        }
    }
}
