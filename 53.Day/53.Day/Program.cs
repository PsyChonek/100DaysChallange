using System;
using System.Collections.Generic;

namespace _53.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "abaa";
            char C = 'b';

             foreach (int I in ShortestToChar(S, C))
               Console.Write(I);
            Console.WriteLine();
        }
        static int[] ShortestToChar(string S, char C)
        {
            List<int> output = new List<int>();
            bool hasBeen = false;
            for (int P = 0; P < S.Length; P++)
            {

                for (int K = 0; K < S.Length; K++)
                {

                    if (hasBeen)
                    {
                        if(P + K < S.Length && P - K > 0)
                        {
                            if (S[P + K] == C || S[P - K] == C)
                            {
                                output.Add(K);
                                break;
                            }
                        }
                        else if(P+K < S.Length)
                        {
                            if (S[P + K] == C)
                            {
                                output.Add(K);
                                break;
                            }
                        }
                        else if (P - K > 0)
                        {
                            if (S[P - K] == C)
                            {
                                output.Add(K);
                                break;
                            }
                        }


                    }
                    else if (S[P+K] == C)
                    {
                        if(K == 0)
                        {
                            hasBeen = true;
                        }

                        output.Add(K);
                        break;
                    }

                }
            }

            return output.ToArray();
        }
    }
}
