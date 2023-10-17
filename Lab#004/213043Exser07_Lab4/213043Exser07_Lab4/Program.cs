using System;

class MatrixMultiplication
{
    static void Main()
    {
        int[,] matrixA = new int[3, 3];
        int[,] matrixB = new int[3, 3];
        int[,] resultMatrix = new int[3, 3];

        Console.WriteLine("Enter values for Matrix A (3x3):");
        ReadMatrix(matrixA);

        Console.WriteLine("Enter values for Matrix B (3x3):");
        ReadMatrix(matrixB);

        MultiplyMatrices(matrixA, matrixB, resultMatrix);

        Console.WriteLine("Resultant Matrix R (A x B):");
        PrintMatrix(resultMatrix);

        Console.ReadLine();
    }

    static void ReadMatrix(int[,] matrix)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Enter value for [{row + 1},{col + 1}]: ");
                if (!int.TryParse(Console.ReadLine(), out matrix[row, col]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    col--; // Retry the current column
                }
            }
        }
    }

    static void MultiplyMatrices(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}
