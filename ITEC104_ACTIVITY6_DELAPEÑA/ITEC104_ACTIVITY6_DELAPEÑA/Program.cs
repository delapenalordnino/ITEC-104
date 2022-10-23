using System;

namespace ITEC104_ACTIVITY6_DELAPEÑA
{
    class Program
    {
        static void Main(string[] args)
        {   //hashset 1
            HashSet<int> h1 = new HashSet<int>();
            Console.Write("====HashSet 1====");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Element {0}: ",i);
                h1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();

            //hashset 2
            Console.Write("====HashSet 2====");
            Console.WriteLine();
            HashSet<int> h2 = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Element {0}: ",i);
                h2.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();
            //code to display union
            HashSet<int> h3 = new HashSet<int>(h1);
            h3.UnionWith(h2);
            Console.Write("UNION: ");
            foreach (int i in h3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            //code to display intersection
            HashSet<int> h4 = new HashSet<int>(h1);
            h4.IntersectWith(h2);
            Console.Write("INTERSECTION: ");
            foreach (int i in h4)

            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            //code to display set difference
            HashSet<int> h5 = new HashSet<int>(h1);
            h5.ExceptWith(h2);
            Console.Write("SET DIFFERENCE: ");
            foreach (int i in h5)
            {
                Console.Write(i + " ");
            }

        }

    }
}