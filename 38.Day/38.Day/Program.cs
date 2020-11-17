using System;

namespace _38.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 4;
            Console.WriteLine(HammingDistance(x,y));
        }
        static int HammingDistance(int x, int y)
        {
            int result = 0;
            
            string x_byts = Convert.ToString(x, 2);
            string y_byts = Convert.ToString(y, 2);

            while (x_byts.Length != y_byts.Length)
            {
                if (x_byts.Length < y_byts.Length)
                {
                    x_byts = "0" + x_byts;
                }
                else
                {
                    y_byts = "0" + y_byts;
                }
            }

            for (int P = 0; P < x_byts.Length; P++)
            {
                if (x_byts[P] != y_byts[P])
                {
                    result++;
                }
            }
            return result;     
        }
    }
}
