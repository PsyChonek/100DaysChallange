using System;

namespace _9.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            Console.WriteLine(NumIdenticalPairs(nums));
            Console.WriteLine();

            string address = "1.1.1.1";
            Console.WriteLine(DefangIPaddr(address));
            Console.WriteLine();

            string J = "aA", S = "aAAbbbb";
            Console.WriteLine(NumJewelsInStones(J,S));
            Console.WriteLine();

        }

        static int NumIdenticalPairs(int[] nums)
        {
            int result = 0;
            for (int P = 0; P < nums.Length; P++)
            {
                for (int M = P + 1; M < nums.Length; M++)
                {
                    if (nums[P] == nums[M])
                    {
                        result++;
                    }
                } 
            }
            return result;
        }

        static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        static int NumJewelsInStones(string J, string S)
        {
            int result = 0;
            foreach (char rock in S)
            {
                if (J.Contains(rock))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
