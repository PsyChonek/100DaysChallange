using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _2.Day
{
    class Program
    {
        public class Node
        {
            public int Root;
            public int Left;
            public int Right;
        }

        public static void Main()
        {
            Begin:

            int p = 0;
            Boolean Continue = true;
            int n = 0;
            var rand = new Random();
            
            List<Node> Nodes = new List<Node>();

            Nodes.Add(new Node() { Root = rand.Next(2), Left = rand.Next(3), Right = rand.Next(3) });
            Console.WriteLine();
            Console.WriteLine("P = " + (p + 1) + ";  2 = Blind point");
            Console.WriteLine();
            Console.WriteLine("Root: " +Nodes[n].Root + "; L: " + Nodes[n].Left + "; R: " + Nodes[n].Right);

            n += 1;

            while (Continue)
            {
                Console.WriteLine();
                Console.WriteLine("P= "+ (p+2));


                switch (rand.Next(1, 4))
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("1:");
                        if (Nodes[n - 1].Left != 2)
                        {
                            Nodes.Add(new Node() { Root = Nodes[n - 1].Left, Left = rand.Next(3), Right = rand.Next(3) });
                            Console.WriteLine();
                            Console.WriteLine("Left " + "Root: " + Nodes[n].Root + "; L: " + Nodes[n].Left + "; R: " + Nodes[n].Right);
                            n++;
                        }
                        else
                        {
                            Continue = false;
                        }

                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("2:");
                        if (Nodes[n - 1].Right != 2)
                        { 
                        Nodes.Add(new Node() { Root = Nodes[n - 1].Right, Left = rand.Next(3), Right = rand.Next(3) });
                        Console.WriteLine();
                        Console.WriteLine("Right " + "Root: " + Nodes[n].Root + "; L: " + Nodes[n].Left + "; R: " + Nodes[n].Right);
                        n++;
                        }
                        else
                        {
                            Continue = false;
                        }
                            break;
                        case 3:
                        Console.WriteLine();
                        Console.WriteLine("3:");
                        if (Nodes[n - 1].Left != 2 && Nodes[n - 1].Right != 2)
                        {
                            Nodes.Add(new Node() { Root = Nodes[n - 1].Left, Left = rand.Next(3), Right = rand.Next(3) });
                            Console.WriteLine();
                            Console.WriteLine("Left " + "Root: " + Nodes[n].Root + "; L: " + Nodes[n].Left + "; R: " + Nodes[n].Right);
                            n++;

                            Nodes.Add(new Node() { Root = Nodes[n - 2].Right, Left = rand.Next(3), Right = rand.Next(3) });
                            Console.WriteLine();
                            Console.WriteLine("Right " + "Root: " + Nodes[n].Root + "; L: " + Nodes[n].Left + "; R: " + Nodes[n].Right);
                            n++;
                        }
                        else if (Nodes[n - 1].Left != 2)
                        {
                            Nodes.Add(new Node() { Root = Nodes[n - 1].Left, Left = rand.Next(3), Right = rand.Next(3) });
                            Console.WriteLine();
                            Console.WriteLine("Left " + "Root: " + Nodes[n].Root + "; L: " + Nodes[n].Left + "; R: " + Nodes[n].Right);
                            n++;
                        }
                        else if (Nodes[n - 1].Right != 2)
                        {
                            Nodes.Add(new Node() { Root = Nodes[n - 1].Right, Left = rand.Next(3), Right = rand.Next(3) });
                            Console.WriteLine();
                            Console.WriteLine("Right " + "Root: " + Nodes[n].Root + "; L: " + Nodes[n].Left + "; R: " + Nodes[n].Right);
                            n++;
                        }
                        else
                        {
                            Continue = false;
                        }

                        break;

                    }

                p++;                
            }

            Console.WriteLine("Try again? Y/N");
            string again = Console.ReadLine();
            if (again == "Y")
            {
                Console.Clear();
                goto Begin;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        

    }
}
