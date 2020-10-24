using System;
using System.Collections.Generic;

namespace _14.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };


            foreach (int P in DecompressRLElist(nums))
            {
                Console.WriteLine(P);
            }
        }

        static int[] DecompressRLElist(int[] nums)
        {
            List<int> Nums = new List<int>();
            for (int P = 0; P < nums.Length; P += 2)
            {
                for (int N = 0; N < nums[P]; N++)
                {
                    Nums.Add(nums[P+1]);
                }
            }
            return Nums.ToArray();
        }
    }
}
