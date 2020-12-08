using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Day
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int cnt = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (IsValid(arr1[i], arr2, d))
                    cnt++;
            }
            return cnt;
        }

        private bool IsValid(int num, int[] arr, int d)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(num - arr[i]) <= d)
                    return false;
            }
            return true;
        }
    }
}
