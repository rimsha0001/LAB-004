using System;

class Program
{
    static void Main()
    {
        // Create a rectangular array to store test marks
        int[,] testMarks = new int[5, 10];

        // Initialize the array with test marks (you can modify these values)
        InitializeTestMarks(testMarks);

        // Display the test marks
        DisplayTestMarks(testMarks);

        Console.ReadLine();
    }

    static void InitializeTestMarks(int[,] testMarks)
    {
        // Initialize the test marks (you can modify these values)
        for (int course = 0; course < 5; course++)
        {
            for (int student = 0; student < 10; student++)
            {
                testMarks[course, student] = GenerateRandomTestMark();
            }
        }
    }

    static int GenerateRandomTestMark()
    {
        Random random = new Random();
        return random.Next(0, 101); // Generate a random test mark between 0 and 100
    }

    static void DisplayTestMarks(int[,] testMarks)
    {
        Console.WriteLine("Test Marks for 5 Courses (10 Students each):");

        for (int course = 0; course < 5; course++)
        {
            Console.Write($"Course {course + 1}: ");
            for (int student = 0; student < 10; student++)
            {
                Console.Write(testMarks[course, student] + " ");
            }
            Console.WriteLine();
        }
    }
}