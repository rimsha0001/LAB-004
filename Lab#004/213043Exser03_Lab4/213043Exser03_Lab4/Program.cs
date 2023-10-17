using System;
using static System.Net.Mime.MediaTypeNames;

namespace TaetArray
{
    class Array
    { 
static int checkIfAllVowels(String str)
        {
            int[] hash = {0};

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == 'A' || str[i] == 'a')
                    hash[0] = 1;

                else if (str[i] == 'E' || str[i] == 'e')
                    hash[1] = 1;

                else if (str[i] == 'I' || str[i] == 'i')
                    hash[2] = 1;

                else if (str[i] == 'O' || str[i] == 'o')
                    hash[3] = 1;

                else if (str[i] == 'U' || str[i] == 'u')
                    hash[4] = 1;
            }
          for (int i = 0; i < 5; i++)
            {
                if (hash[i] == 0)
                {
                    return 1;
                }
            }
            return 0;
        }

        static void checkIfAllVowelsArePresent(String str)
        {

            if (checkIfAllVowels(str) == 1)
                Console.Write("Not Accepted\n");
            else
                Console.Write("Accepted\n");
        }

       
        public static void Main(String[] args)
        {
            String str = "aeioubc";
            checkIfAllVowelsArePresent(str);
        }

    }
   
}