using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = { 'h', 'e', 'l', 'l', 'o' };

        }

        static void ReverseString(char[] s)
        {

            for (int P = 0; P < s.Length/2; P++)
            {
                char temp;
                temp = s[P];
                s[P] = s[(s.Length - 1)-P];
                s[(s.Length - 1) - P] = temp;

            }

            return;
        }
    }
}
