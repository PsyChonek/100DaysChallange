using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dvdf";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }

        static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            int begin = 0, length = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // check if current char exists already.
                if (!keyValues.ContainsKey(s[i]))
                {
                    keyValues.Add(s[i], i);
                }
                else
                {
                    // If the found char's position is greater than the begin position, update begin position.
                    if (begin < keyValues[s[i]] + 1)
                        begin = keyValues[s[i]] + 1;

                    // Update the existing char's position to current position.
                    keyValues[s[i]] = i;
                }
                // Update the lenth when current length is longer.
                if (i + 1 - begin > length)
                {
                    length = i + 1 - begin;
                }
            }

            return length;
        }
    }
}
