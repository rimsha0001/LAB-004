using System;

namespace Array
{
    class Program

    {
        static void Main(string[] args)
        {
            int[] numbers = { 1 , 2 , 3 , 4 };
            foreach (int i in numbers)
            {
                Console.Write("{0}", i);
            }
        }

    }
}