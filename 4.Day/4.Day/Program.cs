using System;
using System.Text;

namespace _4.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scrambler(Console.ReadLine()));
        }

        static string Scrambler(string mess)
        {
            StringBuilder ms = new StringBuilder(mess);
            for (int C = 0; C <= 1; C++)
            {
                for (int P = 0; P < ms.Length - 1; P++)
                {
                    int N = 2;
                    while (ms[P] == ms[P + 1])
                    {
                        if ((P + N) < ms.Length && ms[P] == ms[P + N])
                        {                           
                            N += 1;
                        }
                        else if ((P + N) < ms.Length)
                        {
                            var temp = ms[P + 1];
                            ms[P + 1] = ms[P + N];
                            ms[P + N] = temp;
                        }
                        else
                        {
                            break;
                        }
                    }                  
                }
                for (int K = 0; K < ms.Length/2; K++)
                {
                    var temp = ms[ms.Length - 1 - K];
                    ms[ms.Length - 1 - K] = ms[K];
                    ms[K] = temp;
                }
            }
            for (int P = 0; P < ms.Length - 1; P++)
            {
                if (ms[P] == ms[P + 1])
                {
                    return "Error";
                }
            }
                return ms.ToString();
        }
    }
}
