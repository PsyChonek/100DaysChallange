using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 1, 2, 2, 2, 3 };

            foreach (int I in FrequencySort(input))
                Console.WriteLine(I);
        }
        static int[] FrequencySort(int[] nums)
        {
            Array.Sort(nums);

            List<int> number = new List<int>();
            List<int> times = new List<int>();

            foreach (int I in nums)
            {
                if (number.Contains(I) == false)
                {
                    number.Add(I);
                }
            }

            for (int P = 0; P < number.Count; P++)
            {
                int temp = 0;
                for (int I = 0; I < nums.Length; I++)
                {
                    if (number[P] == nums[I])
                    {
                        temp++;
                    }
                }
                times.Add(temp);
            }



            return times.ToArray();



        }
    }
}
