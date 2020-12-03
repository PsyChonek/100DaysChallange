using System;
using System.Collections.Generic;

namespace _53.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "loveleetcode";
            char C = 'e';

             foreach (int I in ShortestToChar(S, C))
               Console.Write(0);
        }
        static int[] ShortestToChar(string S, char C)
        {
            List<int> output = new List<int>();
            bool hasBeen = false;
            for (int P = 0; P < S.Length; P++)
            {

                int distance = -1;

                for (int K = 0; K < S.Length; K++)
                {
                    distance++;
                    if (hasBeen)
                    {
                        Console.WriteLine(K - distance);
                        if (S[K+distance] == C || S[K-distance] == C)
                        {
                            Console.WriteLine("New: " + distance);
                            break;
                        }
                    }
                    else if (S[K] == C)
                    {
                        Console.WriteLine("Old: " + distance);
                        if (distance == 0)
                        {
                            hasBeen = true;
                        }
                        break;
                    }


                }
            }

            return output.ToArray();
        }
    }
}
