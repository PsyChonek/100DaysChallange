using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 8000, 9000, 2000, 3000, 6000, 1000 };
            Console.WriteLine(Average(input));

        }
        static double Average(int[] salary)
        {
            double result = 0;
            Array.Sort(salary);

            for (int P = 1; P < salary.Length - 1; P++)
            {
                result += salary[P];
            }
            result /= salary.Length - 2;
            return result;
        }
    }
}
