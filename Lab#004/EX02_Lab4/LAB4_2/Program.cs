using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] NUMBER2D = new int[3, 2] { { 2, 4 }, { 4, 5 }, { 5, 6 } };
            foreach (int i in NUMBER2D)
            {
                Console.WriteLine("{0}", i);
            }
        }

    }
}