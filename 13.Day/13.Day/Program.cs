using System;
using System.Net.Http.Headers;

namespace _13.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 234;
            Console.WriteLine(SubtractProductAndSum(n));
        }

        static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            while (n > 0)
            {
                int num = n % 10;
                product *= num;
                sum += num;
                n /= 10;
            }
            return product-sum;
        }
    }
}
