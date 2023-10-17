using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initiliz an array
            string[] weekdays = { " Sun", "Mon" , "tues", "wed", "thurs", "fri", "sat " };
            PrintArray(weekdays);
            //Changements in Array 
            ChangeArray(weekdays);

            Console.WriteLine("Array weekdays after the call t chnge array ");
            PrintArray(weekdays);
            Console.WriteLine();
            ChangeArrayElements(weekdays);
            Console.WriteLine();
            Console.WriteLine("Array week days after the call to change week Elements");
            PrintArray(weekdays);
        }
        private static void ChangeArrayElements(string[] weekdays)
        {
            weekdays[0] = "Sat";
            weekdays[1] = "Fri";
            weekdays[2] = "Thu";
        }
        private static void ChangeArray(string[] weekdays)
        {
            weekdays = (weekdays.Reverse()).ToArray();
            Console.WriteLine("arr[0] is {0} in ChangeArray", weekdays[0]);
        }
        public static void PrintArray(string[] weekdays)
        {
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i] + "{0}", i<weekdays.Length - 1 ? " " : " ");

            }
            Console.WriteLine();
        }
    }
}
