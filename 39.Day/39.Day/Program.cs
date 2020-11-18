using System;
using System.Collections.Generic;

namespace _39.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = { 1, 2, 3, 4 }, arr = { 2, 4, 1, 3 };
            Console.WriteLine(CanBeEqual(target, arr));
        }
        static bool CanBeEqual(int[] target, int[] arr)
        {
            List<int> target_list = new List<int>(target);
            List<int> arr_list = new List<int>(arr);

            for (int P = 0; P < target_list.Count; P++)
            {
                for (int T = 0; T < arr_list.Count; T++)
                {
                    if (target_list[P] == arr_list[T])
                    {
                        target_list.RemoveAt(P);
                        arr_list.RemoveAt(T);

                        T = arr_list.Count;
                        P--;
                        
                    } 
                }
            }

            if (target_list.Count == 0)
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
