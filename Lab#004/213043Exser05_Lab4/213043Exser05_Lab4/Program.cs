using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1/2/3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertDecimalToBinary();
                    break;

                case "2":
                    ConvertBinaryToDecimal();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }

    static void ConvertDecimalToBinary()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binary = DecimalToBinary(decimalNumber);
        Console.WriteLine($"Binary: {binary}");
    }

    static string DecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }

    static void ConvertBinaryToDecimal()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = BinaryToDecimal(binaryNumber);
        Console.WriteLine($"Decimal: {decimalNumber}");
    }

    static int BinaryToDecimal(string binaryNumber)
    {
        return Convert.ToInt32(binaryNumber, 2);
    }
}
