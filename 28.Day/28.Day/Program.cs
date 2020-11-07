using System;

namespace _28.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startTime = { 1, 2, 3 };
            int[] endTime = { 3, 2, 7 };
            int queryTime = 4;
            Console.WriteLine(BusyStudent(startTime, endTime, queryTime));
        }
        static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int result = 0;
            for (int P = 0; P < startTime.Length; P++)
            {
                if (startTime[P] <= queryTime && queryTime <= endTime[P])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
