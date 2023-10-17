using System;
namespace TaetArray
{
    class TwoDArray
    {
        static void Main()
        {
            int[,] number = { { 11, 54, 22, }, { 3, 4, 6 } };
            for (int i = 0; i < number.GetLength(0); i++)
            {
                //Console.WriteLine(number[i,0])
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.Write(number[i, j] + "   ");
                }
                Console.WriteLine();
            }

        }
    }
}