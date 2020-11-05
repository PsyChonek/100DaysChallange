using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace _26.Day
{
    class Program
    { 
        static void Main(string[] args)
        {
            IList<IList<string>> paths = new List<IList<string>>();
            paths.Add(new List<String>());
            paths[0].Add("London");
            paths[0].Add("New York");
            paths.Add(new List<String>());
            paths[1].Add("New York");
            paths[1].Add("Lima");
            paths.Add(new List<String>());
            paths[2].Add("Lima");
            paths[2].Add("Sao Paulo");


            Console.WriteLine(DestCity(paths));
        }

        static string DestCity(IList<IList<string>> paths)
        {
            string result = "";
            for (int P = 0; P < paths.Count; P++)
            {
                result = Next(paths, paths[P][1]);
            }
            return result;  
        }

        static string Next(IList<IList<string>> paths,string Test)
        {
            for (int C = 0; C < paths.Count; C++)
            {
                if (paths[C][0] == Test)
                {
                    return Next(paths, paths[C][1]);
                }
            }
            return Test;
        }

    }
}
