using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 0, 0, 0, 1, 2, 2, 2, 3, 5, 5, 5, 5, 6, 6, 7, 7, 8, 8, 10 };

            Console.WriteLine(TrimMean(arr));
            
        }

        static double TrimMean(int[] arr)
        {
            Array.Sort(arr);

            int i = arr.Length * 5 / 100;
            int j = arr.Length - i;

            double val = 0;

            for (int k = i; k < j; k++) 
            { 
                val += arr[k];
            }


            return (i >= j) ? 0 : val / (j - i);
        }
    }
}
