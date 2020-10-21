using System;
using System.Text;

namespace _11.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "codeleet";
            int[] indicates = {4, 5, 6, 7, 0, 2, 1, 3};
            Console.WriteLine(RestoreString(s,indicates));
        }

        static string RestoreString(string s, int[] indices)
        {   
            StringBuilder sb = new StringBuilder(s);
            int P = 0;

            foreach (int I in indices)
            {              
                sb[I] = s[P];
                P++;
            }
            return sb.ToString();
        }
    }
}
