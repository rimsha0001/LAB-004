using System;

class Program
{
    static void Main()
    {
        int[] responses = new int[40]; // An array to store 40 student responses
        int[] frequency = new int[5]; // An array to store the frequency of each rating

        // Collect responses from 40 students
        for (int i = 0; i < responses.Length; i++)
        {
            Console.Write($"Enter response for student {i + 1} (1 to 5): ");
            if (int.TryParse(Console.ReadLine(), out int response) && response >= 1 && response <= 5)
            {
                responses[i] = response;
                frequency[response - 1]++; // Update the frequency array
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter a rating between 1 and 5.");
                i--; // Decrement i to re-enter the response
            }
        }

        // Display the frequency of each rating
        for (int i = 0; i < frequency.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
        }
    }
}
