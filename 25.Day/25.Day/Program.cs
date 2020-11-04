using System;
using System.Text;

namespace _25.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9999;
            Console.WriteLine(Maximum69Number(num));
        }
        static int Maximum69Number(int num)
        {
            string numString = num.ToString();
            StringBuilder sb = new StringBuilder(numString);

            int max = num;
            
            for (int P = 0; P < numString.Length; P++)
            {

                if (sb[P] == '6')
                {

                    sb[P] = '9';

                    if (Int32.Parse(sb.ToString()) > max)
                    {
                        max = Int32.Parse(sb.ToString());
                    }
                    sb[P] = '6';
                    

                }
            }
            return max;
        }
    }
}
