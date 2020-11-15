using System;

namespace _36.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string moves = "LDRRLRUULR";
            Console.WriteLine(JudgeCircle(moves));
        }
        static bool JudgeCircle(string moves)
        {
            int[] position = { 0, 0 };

            foreach (char T in moves)
            {
                if (T == 'U')
                {
                    position[1]++;
                }
                if (T == 'D')
                {
                    position[1]--;
                }
                if (T == 'R')
                {
                    position[0]++;
                }
                if (T == 'L')
                {
                    position[0]--;
                }
            }

            if (position[0] == 0 && position[1] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
