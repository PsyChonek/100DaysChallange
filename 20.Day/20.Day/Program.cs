using System;

namespace _20.Day
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] arr = { 10, 11, 12 };
            Console.WriteLine(SumOddLengthSubarrays(arr));    
        }

        static int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            
            for (int N = 0; N <= arr.Length; N += 2)
            {
                for (int P = 0; P < arr.Length-N; P++)
                {
                    for (int T = 0; T <= N; T++)
                    {
                        sum += arr[P + T];
                    }
                }
            }

            return sum;   
        }

    }


}
