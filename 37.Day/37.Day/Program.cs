using System;
using System.Collections.Generic;

namespace _37.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "IDID";
            foreach (int I in DiStringMatch(S))
            {
                Console.WriteLine(I);
            }
        }
        static int[] DiStringMatch(string S)
        {
            List<int> result = new List<int>();
            int UP = 0;
            int DOWN = S.Length;


            for (int P = 0; P < S.Length; P++)
            {
                if (S[P] == 'I')
                {
                    result.Add(UP);
                    UP++;
                }
                if (S[P] == 'D')
                {
                    result.Add(DOWN);
                    DOWN--;
                }
            }

            if (S.Length == 'I')
            {
                result.Add(UP);
            }
            else
            {
                result.Add(DOWN);
            }

            return result.ToArray();
        }
    }
}
