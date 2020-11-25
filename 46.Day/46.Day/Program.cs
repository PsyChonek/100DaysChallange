using System;
using System.Text;

namespace _46.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Let's take LeetCode contest";
            Console.WriteLine(ReverseWords(input));
        }
        static string ReverseWords(string s)
        {
            StringBuilder output = new StringBuilder(s);

            int min = 0;
            int max = 0;

            for (int P = 0; P < s.Length; P++)
            {
                if (s[P] == ' ' && min + 1 != P)
                {
                    max = P - 1;

                }
                else if (P == s.Length - 1)
                {
                    max = P;
                }
                else if (s[P] == ' ' && min + 1 == P)
                {
                    min = P+1;
                    max = P+1;
                }
                

                if (min != max)
                {
                    int temp = max + 2;

                    while (min != max && max > min)
                    {
                        output[max] = s[min];
                        output[min] = s[max];
                        max--;
                        min++;
                    }
                    
                    min = temp;
                    max = temp;
                }

                    
            }


            return output.ToString();
        }
    }
}
