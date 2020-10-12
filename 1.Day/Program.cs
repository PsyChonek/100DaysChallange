using System;
using System.Security.Cryptography;

namespace _1.Day
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number K.");
            int k = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Array lenght.");
            int[] NumberArray = new int[Int32.Parse(Console.ReadLine())];

            var rand = new Random();

            for (int P = NumberArray.Length - 1; P >= 0; P--){
                NumberArray[P] = rand.Next(k);
            }

            for(int P = NumberArray.Length-1; P >=0; P--)
            {
                Check(NumberArray, k, P);
            }

            foreach(int number in NumberArray)
            {
                Console.Write(number + ", ");
            }

        }

        static void Check(int[] NumberArray,int k,int Position)
        {
            for (int P = NumberArray.Length-1 ; P >= 0; P--)
            {
                if (P != Position)
                {
                    if (NumberArray[Position] + NumberArray[P] == k)
                    {
                        Console.WriteLine("True; Numbers = " +NumberArray[Position] + " + " + NumberArray[P]);
                    } 
                }
            }
        }
    }
}
