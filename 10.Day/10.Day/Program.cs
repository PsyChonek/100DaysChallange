using System;

namespace _10.Dayd
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 14;
            Console.WriteLine(NumberOfSteps(input));

        }
        static int NumberOfSteps(int num)
        {
            int output = 0;

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                output++;
            }
            return output;
        }
    }
}
