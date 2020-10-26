using System;

namespace _16.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "1+(2*3)/(2-1)";
            Console.WriteLine(MaxDepth(test));
        }

        static int MaxDepth(string s)
        {
            int depth = 0;
            int temp = 0;

            for (int P = 0; P < s.Length; P++)
            {
                if (s[P] == '(')
                {
                    temp++;
                }
                else if (s[P] == ')')
                {
                    temp--;
                }

                if (depth < temp)
                {
                    depth = temp;
                }
            }

            return depth;
        }

    }

}
