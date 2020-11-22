using System;
using System.Collections.Generic;

namespace _43.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = {1,2};
            Console.WriteLine(UniqueOccurrences(input));
        }
        static bool UniqueOccurrences(int[] arr)
        {
            List<int> Occurrences = new List<int>();
            List<int> Done = new List<int>();

            for (int P = 0; P< arr.Length; P++)
            {
                 next:
                
                foreach (int I in Done)
                {
                    if (arr.Length < P && I == arr[P])
                    {
                        P++;
                        goto next;
                    }
                    else if (I == arr[P])
                    {
                        goto OuterLoop;
                    }

                }

                Done.Add(arr[P]);
                int Occurrence = 0;

                for (int T = P + 1; T < arr.Length; T++)
                {
                    if (arr[P] == arr[T])
                    {
                        Occurrence++;
                    }
                }



                foreach (int O in Occurrences)
                {
                    if (O == Occurrence)
                    {
                        return false;
                    }
                }

                Occurrences.Add(Occurrence);

            OuterLoop:
                continue;

            }

            if (Occurrences.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
