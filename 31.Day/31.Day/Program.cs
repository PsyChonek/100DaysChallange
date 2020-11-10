using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _31.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            Console.WriteLine(GenerateTheString(n));
        }
        static string GenerateTheString(int n)
        {
            var builder = new StringBuilder();

            for (int P = 0; P<n; P++)
            {
                if (n % 2 == 0)
                {                                
                    while (P != n-1)
                    {
                        builder.Append('a');
                        P++;
                    }
                    builder.Append('b');
                }
                else
                {
                    while (P != n)
                    {
                        builder.Append('a');
                        P++;
                    }
                }
            }

            return builder.ToString();
        }
    }
}
