using System;

namespace _19.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "RLRRRLLRLL";
            Console.WriteLine(BalancedStringSplit(input));
        }
        static int BalancedStringSplit(string s)
        {
            int result = 0;
            int temp = 0;
            for (int P = 0; P < s.Length; P++)
            {
                if (s[P] == 'L')
                {
                    temp++;
                }
                else
                {
                    temp--;
                }
                if (temp == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
