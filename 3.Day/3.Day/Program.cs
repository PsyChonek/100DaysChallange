using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace _3.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating array with numbers
        
            int size = Int32.Parse(Console.ReadLine());

            int[] numbers = new int[size-1];

            for (int n = 0; n < size-1; n++ )
            {
                numbers[n] = n + 2;
            }

            //


            Console.WriteLine();

            // Checking numbers

            foreach (int test in numbers)
            {
                for (int p = 2; p < test; p++)
                {
                    if (test % p == 0)
                    {
                        p = test+1;
                        numbers[test-2] = 0;
                    }
                }

                // Writing prime numbers
                if (numbers[test - 2] != 0) { Console.Write(numbers[test - 2] + " "); }

            }

            //

            
            Console.WriteLine();
            Console.WriteLine();

            for (int y = 2; y < size; y++)
            {
                Boolean prime = true;
                for (int x = 2; x < y; x++)
                {
                    if (y % x == 0)
                    {
                        x = y;
                        prime = false;
                    }
                }
                if (prime)
                {
                    Console.Write(y + " ");
                }
            }
        }
    }
}
