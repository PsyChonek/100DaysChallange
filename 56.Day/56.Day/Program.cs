using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 4;

            Console.WriteLine(Fib(input));
        }
        static int Fib(int N)
        {
            int second = 0;
            int first = 1;
            int output = 0;

            if (N > 0)
            {
                output++;
                for (int P = 1; P <= N; P++)
                {
                    output = second + first;
                    first = second;
                    second = output;

                }
            }



            return output;
                
        }
    }
}
