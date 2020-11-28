using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abbaca";

            Console.WriteLine(RemoveDuplicates(input));
        }
        static string RemoveDuplicates(string S)
        {
            StringBuilder output = new StringBuilder(S);

            bool right = false;

            while (!right)
            {
                right = true;
                for (int P = 0; P < output.Length-1; P++)
                {
                    if (output[P] == output[P + 1])
                    {
                        output.Remove(P,2);
                        right = false;
                    }
                }
            }


            return output.ToString();           
        }
    }
}
