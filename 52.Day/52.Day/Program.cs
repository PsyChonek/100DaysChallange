using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = {"bella","label","roller"};
            foreach (string I in CommonChars(input))
            Console.WriteLine();
        }
        static IList<string> CommonChars(string[] A)
        {
            List<char> Common = new List<char>();

            foreach (char C in A[0])
            {
                Common.Add(C);
            }
            Console.Write("Písmenka jsou: ");
            foreach (char C in Common)
            {
                Console.Write(C);
            }
            Console.WriteLine();

            for (int P = 1; P < A.Length; P++)
            {

                for (int Ch = 0; Ch < Common.Count; Ch++)
                {
                    bool isIn = false;
                    for (int C = 0; C < A[P].Length; C++)
                    {
                        if (A[P][C] == Common[Ch])
                        {
                            Console.WriteLine("Slovo: " + A[P] + " Obsahuje: " + Common[Ch] + " Na indexu: " + C);
                            isIn = true;
                            A[P] = A[P].Substring(0, C) + A[P].Substring(C+1, A[P].Length-1-C);
                            Console.WriteLine(A[P]);
                        }
                    }
                    

                    if (!isIn)
                    {
                        Common.RemoveAt(Ch);
                        Console.Write("Seznam: ");
                        foreach (char C in Common)
                        {
                            Console.Write(C);
                        }

                        Console.WriteLine();
                    }
                }
            }

            return Common.Select(c => c.ToString()).ToList();
        }
    }


}
