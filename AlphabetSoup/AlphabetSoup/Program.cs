using System;

namespace AlphabetSoup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string:");
            Console.WriteLine("\noutput: " + AlphabetSoup(Console.ReadLine()));

            Console.ReadLine();
        }


        static string AlphabetSoup(string input)
        {
            input = input.ToLower();
            string output = string.Empty;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int x = 0; x < input.Length; x++)
                {
                    if (alphabet[i] == input[x])
                    {
                        output += alphabet[i];
                    }
                }
            }

            return output;
        }
    }
}
